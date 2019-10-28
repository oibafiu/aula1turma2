using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculandoIdade.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalculoImcController : ApiController
    {
        public string Post(Pessoa pessoa)
        {
            var imc = pessoa.Peso/ (pessoa.Altura * pessoa.Altura);
            return $"Olá {pessoa.Nome} , seu IMC é {imc.ToString("N2")}";
        }
    }
}
