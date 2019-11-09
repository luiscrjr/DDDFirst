using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Application
{
    public class TokenConfiguration
    {
        //Define quem poderá utilizar o TOKEN
        public string Audience { get; set; }

        //Define o nome da API que gerou o TOKEN
        public string Issuer { get; set; }

        //Definir o tempo de expiração do TOKEN
        public int Seconds { get; set; }




    }
}
