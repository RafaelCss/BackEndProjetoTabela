using Dominio.Entidade;
using Dominio.Interfaces.IServico;
using Dominio.Interfaces.IServicos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servico
{
	public class ServicoFruta : IServicoFruta
	{
		private readonly IRepositorioFruta _servicoFruta;

		public ServicoFruta(IRepositorioFruta servicoFruta) 
		{
			_servicoFruta= servicoFruta;
		}

		public async Task<IEnumerable> BuscarTodos()
		{
			var resuiltado = await _servicoFruta.BuscarTodos();

			return resuiltado;
		}

		public async Task Cadastar(Fruta fruta)
		{
			var resultado = new Fruta(fruta.Nome, fruta.ValorA , fruta.ValorB);
			await _servicoFruta.CadastrarFruta(resultado);
		}

		public Task Filtrar()
		{
			throw new NotImplementedException();
		}

		public Task Modificar()
		{
			throw new NotImplementedException();
		}
	}
}
