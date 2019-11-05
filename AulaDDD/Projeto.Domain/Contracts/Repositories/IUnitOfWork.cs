using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Contracts.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();

        ICategoriaRepository CategoriaRepository { get;}
        IContatoRepository ContatoRepository { get;}
        IEnderecoRepository EnderecoRepository { get;}
        IFornecedorRepository FornecedorRepository { get;}
        IMarcaRepository MarcaRepository { get;}
        IProdutoRepository ProdutoRepository { get;}
    }
}
