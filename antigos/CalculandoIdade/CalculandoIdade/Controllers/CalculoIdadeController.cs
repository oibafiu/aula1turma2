using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculandoIdade.Controllers
{
    public class CalculoIdadeController : ApiController
    {
        public string Get(int anoNascimento, string nomeUsuario = "")
        {
            

            if((DateTime.Now.Year -  anoNascimento) >= 18)
            {
                return $"Olá {nomeUsuario} Beba abelzinho";
            }
            else
            {
                return $"Olá {nomeUsuario} Beba leite abelzinho";
            }
        }
        
    }
}
