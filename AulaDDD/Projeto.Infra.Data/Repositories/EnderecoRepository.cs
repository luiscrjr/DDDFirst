using Projeto.Domain.AggregatesModel.FornecedorAggregate;
using Projeto.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class EnderecoRepository 
        : BaseRepository<Endereco>, IEnderecoRepository
    {

    }
}
