using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.AggregatesModel.ProdutoAggregate
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        #region Navegabilidade

        public int IdProduto { get; set; }
        public Produto Produto { get; set; }

        #endregion
    }
}
