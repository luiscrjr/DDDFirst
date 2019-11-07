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
    public class EntityToModelProfile : Profile
    {
        public EntityToModelProfile()
        {
            CreateMap<Fornecedor, FornecedorConsultaModel>();
            CreateMap<Produto, ProdutoConsultaModel>();
        }
    }
}
