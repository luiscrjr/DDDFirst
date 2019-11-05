using Projeto.Domain.AggregatesModel.ProdutoAggregate;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class CategoriaRepository 
        : BaseRepository<Categoria>, ICategoriaRepository
    {
        private readonly DataContext dataContext;

        public CategoriaRepository(DataContext dataContext)
            : base(dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}
