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
			if(valorA < 0)
				ValorA = valorA;
			//AddNotification(new Notification("ValorA","Este campo não pode ficar vazio"));
		}

		private void ValidarValorB(decimal valorB)
		{
			if(valorB < 0)
				ValorB = valorB;
			//AddNotification(new Notification("ValorB","Este campo não pode ficar vazio"));
		}

		private void ValidarNome(string nome)
		{
			if(!String.IsNullOrEmpty(nome))
				Nome = nome;
			//AddNotification(new Notification("Nome","Este campo não pode ficar vazio"));
		}

	}
}
