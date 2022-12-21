using Dominio.Entidade;
using Dominio.Interfaces.IServicos;
using Infra.Contexto;
using Infra.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infra.RepositorioFruta
{
	public class RepositorioFruta : RepositorioBase<Fruta> , IRepositorioFruta
	{
		public RepositorioFruta(ContextoDataBase contextoDataBase) : base(contextoDataBase)
		{
		}

		public Task<Fruta> BuscarFruta(string id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Fruta>> BuscarTodasFrutas()
		{
			var resuiltado = await BuscarTodos();
			
			return resuiltado.ToList();
		}

		public async Task CadastrarFruta(Fruta fruta)
		{
			 await Inserir(fruta);
		}
	}
}
