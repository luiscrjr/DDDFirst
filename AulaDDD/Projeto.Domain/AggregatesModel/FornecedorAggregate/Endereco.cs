using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.AggregatesModel.FornecedorAggregate
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        #region Navegabilidade

        public int IdFornecedor { get; set; }
        public Fornecedor Fornecedor { get; set; }

        #endregion
    }
}
