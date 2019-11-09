using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // Validações dos campos

namespace Projeto.Application.Models
{
    public class ProdutoCadastroModel
    {
        [Required(ErrorMessage = "Nome obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preço obrigatório.")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Quantidade obrigatório.")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Id do Fornecedor obrigatório.")]
        public int IdFornecedor { get; set; }
    }
}
