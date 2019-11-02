using Projeto.Domain.AggregatesModel.ProdutoAggregate;
using Projeto.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class MarcaRepository 
        : BaseRepository<Marca>, IMarcaRepository
    {

    }
}
