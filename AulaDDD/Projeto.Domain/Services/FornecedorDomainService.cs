using Projeto.Domain.AggregatesModel.FornecedorAggregate;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public class FornecedorDomainService 
        : BaseDomainService<Fornecedor>, IFornecedorDomainService
    {
        //atributo
        private readonly IUnitOfWork unitOfWork;

        //ctor c entrada de argumentos
        public FornecedorDomainService(IUnitOfWork unitOfWork)
            :base(unitOfWork.FornecedorRepository) // superclasse
        {
            this.unitOfWork = unitOfWork;
        }
    }
}

