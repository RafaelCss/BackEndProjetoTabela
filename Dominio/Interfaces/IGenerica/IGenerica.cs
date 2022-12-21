using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.IGenerica
{
	public interface IGenerica<T>  where T : class 
	{
		Task<List<T>> BuscarTodos();
		Task BuscarPorID(Guid objId);
		Task Inserir(T obj);
		Task Delete(int objId);
		Task Update(T obj);
		void Save();
	}
}
