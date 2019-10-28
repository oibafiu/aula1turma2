using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculandoIdade.Controllers
{
    public class CalculoImcController : ApiController
    {
        public string Get(int peso, string nomeUsuario = "", int altura)
        {

            var imc = peso / (altura * altura);
            return $"Olá {nomeUsuario} , seu IMC é {imc}...";
        }
    }
}
