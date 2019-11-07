using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // Validações dos campos

namespace Projeto.Application.Models
{
    public class FornecedorConsultaModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string RazaoSocial { get; set; }

        public string Cnpj { get; set; }
    }
}
