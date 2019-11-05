using Projeto.Domain.AggregatesModel.FornecedorAggregate;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class FornecedorRepository 
        : BaseRepository<Fornecedor>, IFornecedorRepository
    {
        private readonly DataContext dataContext;

        public FornecedorRepository(DataContext dataContext)
            : base(dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}
