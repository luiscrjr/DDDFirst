using Projeto.Domain.AggregatesModel.ProdutoAggregate;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class MarcaRepository 
        : BaseRepository<Marca>, IMarcaRepository
    {
        private readonly DataContext dataContext;

        public MarcaRepository(DataContext dataContext)
            : base(dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}
