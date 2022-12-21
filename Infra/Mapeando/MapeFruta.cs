using Dominio.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Mapeando
{
	public class MapeFruta : IEntityTypeConfiguration<Fruta>
	{
		public void Configure(EntityTypeBuilder<Fruta> builder)
		{
			
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Nome);
			builder.Property(x => x.ValorA);
			builder.Property(x => x.ValorB);
			
		}
	}
}
