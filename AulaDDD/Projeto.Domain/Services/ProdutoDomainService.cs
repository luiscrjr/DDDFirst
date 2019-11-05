using Projeto.Domain.AggregatesModel.ProdutoAggregate;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public class ProdutoDomainService
        : BaseDomainService<Produto>, IProdutoDomainService
    {
        //atributo
        private readonly IUnitOfWork unitOfWork;

        public ProdutoDomainService(IUnitOfWork unitOfWork)
            :base(unitOfWork.ProdutoRepository)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
