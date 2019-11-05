using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiBancoExistente.Models;

namespace WebApiBancoExistente.Controllers
{
    public partial class CarroesController
    {
        
        [HttpGet]
        [Route("Api/Carroes/CustomQuery")]
        public object CustomCarrosQuery()
        {
            var listaDeCarros = db.Carros.ToList();

            var retornoCarros = from carros in listaDeCarros
                                select new
                                {
                                    NomeCarro = carros.Modelo,
                                    CarroId = carros.Id
                                };
            return retornoCarros;
        }
        [HttpGet]
        [Route("Api/Carroes/CarrosComMarcas")]
        public object CustomCarrosOnMarcas()
        {
            var listaCarros = db.Carros.ToList();
            var listaMarcas = db.Marcas.ToList();

            var conteudoRetorno = from marcas in listaMarcas
                                  join carros in listaCarros on marcas.Id equals
                                  carros.Marca
                                  select new
                                  {
                                      CarroId = carros.Id,
                                      CarroNome = carros.Modelo,
                                      MarcaId = marcas.Id,
                                      MarcaNome = marcas.Nome
                                  };
            return conteudoRetorno;
        }
        [HttpGet]
        [Route("Api/Carroes/CarrosUsuarios")]
        public object CustomCarrosPorUsuario(int IdCarro)
        {


            var listaCarros = db.Carros.Where(p => p.Id == IdCarro).ToList();
            var listaUsuarios = db.Usuarios.ToList();

            var conteudoRetorno = from carros in listaCarros
                                  join usuarios in listaUsuarios on carros.UsuInc equals
                                  usuarios.Id

                                  select new
                                  {
                                      CarroId = carros.Id,
                                      CarroNome = carros.Modelo,
                                      UsuarioId = usuarios.Id,
                                      UsuarioNome = usuarios.Usuario1
                                  };
            return conteudoRetorno;
        }


    }
}