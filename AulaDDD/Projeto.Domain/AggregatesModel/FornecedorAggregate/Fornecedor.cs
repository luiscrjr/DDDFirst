using Projeto.Domain.AggregatesModel.ProdutoAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.AggregatesModel.FornecedorAggregate
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }

        #region Navegabilidade

        public ICollection<Contato> Contatos { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
        public ICollection<Produto> Produtos { get; set; }

        #endregion

    }
}
