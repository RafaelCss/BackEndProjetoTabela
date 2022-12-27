using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
	public class EntidadePadrao : Notifiable<Notification>
	{
		public Guid Id { get; set; }
		public DateTime DataCriacao { get; set; }


		public EntidadePadrao()
		{
			IserirData();
		}


		private void IserirData()
		{
			var data = DateTime.Now;
			DataCriacao = data;
		}
	}
}
