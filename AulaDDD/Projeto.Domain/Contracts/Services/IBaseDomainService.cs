using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Contracts.Services
{
    public interface IBaseDomainService<AggregateModel> : IDisposable
        where AggregateModel : class
    {
        void Cadastrar(AggregateModel obj);
        void Atualizar(AggregateModel obj);
        void Remover(AggregateModel obj);

        List<AggregateModel> ObterTodos();
        AggregateModel ObterPorId(int id);

    }
}
