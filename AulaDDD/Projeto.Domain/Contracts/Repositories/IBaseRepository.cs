using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Contracts.Repositories
{
    public interface IBaseRepository<TEntity> : IDisposable
        where TEntity : class
    {
        void Create(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);

        List<TEntity> FindAll();
        TEntity FindById(int id);
    }
}
