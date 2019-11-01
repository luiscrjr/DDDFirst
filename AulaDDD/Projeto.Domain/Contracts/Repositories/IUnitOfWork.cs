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

        ICategoriaRepository CategoriaRepository { get; set; }
        IContatoRepository ContatoRepository { get; set; }
        IEnderecoRepository EnderecoRepository { get; set; }
        IFornecedorRepository FornecedorRepository { get; set; }
        IMarcaRepository MarcaRepository { get; set; }
        IProdutoRepository ProdutoRepository { get; set; }
    }
}
