using Dominio.Entidade;
using Infra.Mapeando;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Contexto
{
	public class ContextoDataBase : DbContext
	{
		public ContextoDataBase( DbContextOptions<ContextoDataBase> options ) : base(options) 
		{ }

		public DbSet<Fruta> Frutas { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new MapeFruta());

			base.OnModelCreating(modelBuilder);
		}

	}
}
