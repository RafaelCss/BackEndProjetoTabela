using Dominio.Entidade;
using Dominio.Interfaces.IResposta;
using Dominio.Interfaces.IServicos;
using Dominio.Servico.Respostas;
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
		Task<IEnumerable> Cadastar(Fruta fruta);
		Task Filtrar();
	}
}
