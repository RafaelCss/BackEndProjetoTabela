using Dominio.Entidade;
using Dominio.Interfaces.IServicos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.IServico
{
	public interface IServicoFruta
	{
		Task<IEnumerable> BuscarTodos();
		Task Modificar();
		Task Cadastar(Fruta fruta);
		Task Filtrar();
	}
}
