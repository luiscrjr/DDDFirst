using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Services;
using Projeto.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Application
{
    public class DependencyResolver
    {
        //método para registrar os mapeamentos de injeção de dependencia

        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IFornecedorDomainService, FornecedorDomainService>();
            services.AddTransient<IProdutoDomainService, ProdutoDomainService>();

            services.AddTransient<IContatoRepository, ContatoRepository>();
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IEnderecoRepository, EnderecoRepository>();
            services.AddTransient<IFornecedorRepository, FornecedorRepository>();
            services.AddTransient<IMarcaRepository, MarcaRepository>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
