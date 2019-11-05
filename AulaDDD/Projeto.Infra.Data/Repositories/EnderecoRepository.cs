using Projeto.Domain.AggregatesModel.FornecedorAggregate;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class EnderecoRepository 
        : BaseRepository<Endereco>, IEnderecoRepository
    {
        private readonly DataContext dataContext;

        public EnderecoRepository(DataContext dataContext)
            : base(dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}
