using Microsoft.EntityFrameworkCore.Storage;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        //atributo para a classe de contexto
        private readonly DataContext dataContext;
        private IDbContextTransaction transaction;


        //construtor para receber o contexto como argumento
        public UnitOfWork(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void BeginTransaction()
        {
            transaction = dataContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public ICategoriaRepository CategoriaRepository => new CategoriaRepository(dataContext);
        public IContatoRepository ContatoRepository => new ContatoRepository(dataContext);
        public IEnderecoRepository EnderecoRepository => new EnderecoRepository(dataContext);
        public IFornecedorRepository FornecedorRepository => new FornecedorRepository(dataContext);
        public IMarcaRepository MarcaRepository => new MarcaRepository(dataContext);
        public IProdutoRepository ProdutoRepository => new ProdutoRepository(dataContext);

        public void Dispose()
        {
            dataContext.Dispose();
        }

       
    }
}
