using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
	public class Fruta : EntidadePadrao
	{
		public Fruta() { }	

		public Fruta(string nome , decimal valorA, decimal valorB)
		{
			ValidarNome(nome);
			ValidarValorA(valorA); 
			ValidarValorB(valorB);
		}
		

		public string Nome { get; set;}
		public decimal ValorA { get; set;}
		public decimal ValorB { get; set; }
	
		private void ValidarValorA(decimal valorA)
		{
			if(valorA >= 1)
				ValorA = valorA;
			AddNotification("ValorA","Este campo não pode ficar vazio");
		}

		private void ValidarValorB(decimal valorB)
		{
			if(valorB >= 1)
				ValorB = valorB;
			AddNotification("ValorB","Este campo não pode ficar vazio");
		}

		private void ValidarNome(string nome)
		{
			if(!String.IsNullOrEmpty(nome))
				Nome = nome;
			AddNotification("Nome","Este campo não pode ficar vazio");
		}

	}
}
