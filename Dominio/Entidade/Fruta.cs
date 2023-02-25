using Flunt.Notifications;
using Flunt.Validations;
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
	
		private Fruta ValidarValorA(decimal valorA)
		{
			if(valorA >= 1)
				ValorA = valorA;
			AddNotifications(new Contract<Fruta>()
				.Requires()
				.IsMinValue(ValorA, "ValorA","Este campo não pode ficar vazio")
				);
			return this;
		}

		private Fruta ValidarValorB(decimal valorB)
		{
			if(valorB >= 1)
				ValorB = valorB;
			AddNotification("ValorB","Este campo não pode ficar vazio");

			return this;
		}

		private Fruta ValidarNome(string nome)
		{
			if(!String.IsNullOrEmpty(nome))
				Nome = nome;
			AddNotifications(new Contract<Fruta>()
				.Requires()
				.IsNotNullOrWhiteSpace(Nome, "Nome","Este campo não pode ficar vazio"));
			return this;
		}

	}
}
