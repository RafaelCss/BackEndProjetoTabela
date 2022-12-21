using Dominio.Entidade;
using Dominio.Interfaces.IGenerica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.IServicos
{
	public interface IRepositorioFruta : IGenerica<Fruta>
	{
		Task<Fruta> BuscarFruta(string id);
		Task<List<Fruta>> BuscarTodasFrutas();
		Task CadastrarFruta( Fruta fruta);
	}
}
