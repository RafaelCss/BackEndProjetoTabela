using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.IResposta
{
	public interface IResposta<T> where T : class
	{
		public List<T> Avisos { get; set; }

	}
}
