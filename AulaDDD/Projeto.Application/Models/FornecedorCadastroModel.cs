using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // Validações dos campos

namespace Projeto.Application.Models
{
    public class FornecedorCadastroModel
    {
        [Required(ErrorMessage = "Nome obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Razão social obrigatória.")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Cnpj obrigatório.")]
        public string Cnpj { get; set; }
    }
}
