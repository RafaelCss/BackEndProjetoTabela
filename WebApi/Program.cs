using Dominio.Interfaces.IServico;
using Dominio.Interfaces.IServicos;
using Dominio.Servico;
using Infra.Contexto;
using Infra.RepositorioFruta;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

#region //config Cors
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
	builder.Services.AddCors(options =>
	{
		options.AddPolicy(name: MyAllowSpecificOrigins,policy => policy.WithOrigins("http://localhost:3000","*"));
		options.AddPolicy("AllowGetMethod",policy => policy.WithMethods("GET","POST"));
	});
#endregion
// Configuração banco de dados

var connectioDataBase = builder.Configuration.GetConnectionString("connectionMysql");
builder.Services.AddDbContext<ContextoDataBase>(opt =>
	opt.UseMySql(connectioDataBase,ServerVersion.AutoDetect(connectioDataBase)));

// Configuração Entidades

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllers();
builder.Services.AddTransient<IServicoFruta,ServicoFruta>();
builder.Services.AddTransient<IRepositorioFruta,RepositorioFruta>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if(app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
app.UseCors( c =>
{
	c.AllowAnyHeader();
	c.AllowAnyMethod();
	c.AllowAnyOrigin();
});
app.UseAuthorization();

app.MapControllers();

app.Run();
