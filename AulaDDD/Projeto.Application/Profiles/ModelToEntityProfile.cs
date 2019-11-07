using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Projeto.Domain.AggregatesModel.FornecedorAggregate;
using Projeto.Domain.AggregatesModel.ProdutoAggregate;
using Projeto.Application.Models;

namespace Projeto.Application.Profiles
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<FornecedorCadastroModel, Fornecedor>();
            CreateMap<FornecedorEdicaoModel, Fornecedor>();

            CreateMap<ProdutoCadastroModel, Produto>();
            CreateMap<ProdutoEdicaoModel, Produto>();
        }
    }
}
