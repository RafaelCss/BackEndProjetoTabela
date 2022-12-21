using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
	public class Fruta
	{
		public Guid Id { get; set; }
		public string Nome { get; set;}
		public decimal ValorA { get; set;}
		public decimal ValorB { get; set; }
	
	}
}
