using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public abstract class BaseDomainService<TEntity> : IBaseDomainService<TEntity>
        where TEntity : class
    {
        //atributo para acessar os métodos do repositório
        private readonly IBaseRepository<TEntity> repository;

        //construtor com entrada de argumentos
        protected BaseDomainService(IBaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public virtual void Cadastrar(TEntity obj)
        {
            repository.Create(obj);
        }

        public virtual void Atualizar(TEntity obj)
        {
            repository.Update(obj);
        }

        public virtual void Remover(TEntity obj)
        {
            repository.Delete(obj);
        }

        public virtual List<TEntity> ObterTodos()
        {
            return repository.FindAll();
        }

        public virtual TEntity ObterPorId(int id)
        {
            return repository.FindById(id);
        }

        public void Dispose()
        {
            repository.Dispose();
        }
    }
}
