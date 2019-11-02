using Projeto.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public ICategoriaRepository CategoriaRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IContatoRepository ContatoRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnderecoRepository EnderecoRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IFornecedorRepository FornecedorRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IMarcaRepository MarcaRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IProdutoRepository ProdutoRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
