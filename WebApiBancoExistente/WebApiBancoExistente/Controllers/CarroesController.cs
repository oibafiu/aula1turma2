using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiBancoExistente.Models;

namespace WebApiBancoExistente.Controllers
{
    public partial class CarroesController : ApiController
    {
        private DataBaseContext db = new DataBaseContext();
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

        // GET: api/Carroes
        public IQueryable<Carro> GetCarros()
        {
            return db.Carros;
        }

        // GET: api/Carroes/5
        [ResponseType(typeof(Carro))]
        public IHttpActionResult GetCarro(int id)
        {
            Carro carro = db.Carros.Find(id);
            if (carro == null)
            {
                return NotFound();
            }

            return Ok(carro);
        }

        // PUT: api/Carroes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCarro(int id, Carro carro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != carro.Id)
            {
                return BadRequest();
            }

            db.Entry(carro).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Carroes
        [ResponseType(typeof(Carro))]
        public IHttpActionResult PostCarro(Carro carro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Carros.Add(carro);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = carro.Id }, carro);
        }

        // DELETE: api/Carroes/5
        [ResponseType(typeof(Carro))]
        public IHttpActionResult DeleteCarro(int id)
        {
            Carro carro = db.Carros.Find(id);
            if (carro == null)
            {
                return NotFound();
            }

            db.Carros.Remove(carro);
            db.SaveChanges();

            return Ok(carro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarroExists(int id)
        {
            return db.Carros.Count(e => e.Id == id) > 0;
        }
    }
}