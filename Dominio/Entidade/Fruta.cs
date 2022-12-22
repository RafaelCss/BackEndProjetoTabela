using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
	public class Fruta
	{
		public Fruta() { }	

		public Fruta(string nome , decimal valorA, decimal valorB)
		{
			ValidarNome(nome);
			ValidarValorA(valorA);
			ValidarValorB(valorB);
		}

		public Guid Id { get; set; }
		public string Nome { get; set;}
		public decimal ValorA { get; set;}
		public decimal ValorB { get; set; }
	
		private void ValidarValorA(decimal valorA)
		{
			if(valorA < 0)
				ValorA = valorA;			
		}

		private void ValidarValorB(decimal valorB)
		{
			if(valorB < 0)
				ValorB = valorB;
		}

		private void ValidarNome(string nome)
		{
			if(!String.IsNullOrEmpty(nome))
				Nome = nome;
		}

	}
}
