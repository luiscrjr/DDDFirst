using Projeto.Domain.AggregatesModel.FornecedorAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.AggregatesModel.ProdutoAggregate
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        #region Navegabilidade

        public Categoria Categoria { get; set; }
        public Marca Marca { get; set; }

        public int IdFornecedor { get; set; }
        public Fornecedor Fornecedor { get; set; }

        #endregion
    }
}
