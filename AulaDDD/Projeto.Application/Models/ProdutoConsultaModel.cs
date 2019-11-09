using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // Validações dos campos

namespace Projeto.Application.Models
{
    public class ProdutoConsultaModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public int Quantidade { get; set; }

        public int IdFornecedor { get; set; }
    }
}
