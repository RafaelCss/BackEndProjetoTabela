using Dominio.Interfaces.IResposta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servico.Respostas
{
	public class Resposta<T> : IResposta<T> where T : class
	{
		public List<T> Avisos { get; set; }
	}
}
