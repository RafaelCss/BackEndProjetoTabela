using Dominio.Interfaces.IGenerica;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Infra.Repositorio
{
	public class RepositorioBase<T> : IGenerica<T>, IDisposable where T : class
	{
		private readonly ContextoDataBase _contextoDataBase;

		public RepositorioBase(ContextoDataBase contextoDataBase)
		{
			_contextoDataBase = contextoDataBase;
		}

		protected DbSet<T> Entidade
		{
			get { return _contextoDataBase.Set<T>(); }
		}

		public async Task BuscarPorID(Guid objId)
		{
			throw new NotImplementedException();
		}

		public  async Task<List<T>> BuscarTodos()
		{
			var resultado =	await Entidade.ToListAsync();
			return resultado;
		}

		public async Task Delete(int objId)
		{
			throw new NotImplementedException();
		}

		public async Task Update(T obj)
		{
			throw new NotImplementedException();
		}

		public async Task Inserir(T obj)
		{
			await Entidade.AddAsync(obj);
			Salvar();
		}

		public void Salvar()
		{
			_contextoDataBase.SaveChangesAsync();
		}

		#region //Configurando dispose

		private bool disposed = false;

		protected virtual void Dispose(bool disposing)
		{
			if(!this.disposed)
			{
				if(disposing)
				{
					_contextoDataBase.Dispose();
				}
			}
			this.disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		public void Save()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
