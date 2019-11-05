using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {

        //atributo
        private readonly DataContext dataContext;

        protected BaseRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Create(TEntity obj)
        {
            dataContext.Entry(obj).State = EntityState.Added;
            dataContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            dataContext.Entry(obj).State = EntityState.Added;
            dataContext.SaveChanges();
        }

        public void Delete(TEntity obj)
        {
            dataContext.Entry(obj).State = EntityState.Deleted;
            dataContext.SaveChanges();
        }

        public List<TEntity> FindAll()
        {
            return dataContext.Set<TEntity>().ToList();
        }

        public TEntity FindById(int id)
        {
            return dataContext.Set<TEntity>().Find(id);
        }

        public void Dispose()
        {
            dataContext.Dispose();
        }
    }
}
