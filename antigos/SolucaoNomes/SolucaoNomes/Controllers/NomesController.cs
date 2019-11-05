using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SolucaoNomes.Models;

namespace SolucaoNomes.Controllers
{
    public class NomesController : ApiController
    {

        List<Pessoa> listaDeObjetos = new List<Pessoa>()
        {
            new Pessoa(){ Nome = "Fabio", Idade = 23},
            new Pessoa(){ Nome = "Felipe", Idade = 27},
            new Pessoa(){ Nome = "Daniel", Idade = 36},
            new Pessoa(){ Nome = "Robson", Idade = 25},
            new Pessoa(){ Nome = "Arisvaldo", Idade = 85}
        };
        public List<Pessoa> Get()
        {
            return listaDeObjetos;
        }
        public Pessoa Post(Pessoa values)
        {
            
            listaDeObjetos.Add(values);

            return values;
        }
    }
}
