using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.AggregatesModel.FornecedorAggregate
{
    public class Contato
    {
        public int Id { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        #region Navegabilidade

        public int IdFornecedor { get; set; }
        public Fornecedor Fornecedor { get; set; }
        #endregion
    }
}
