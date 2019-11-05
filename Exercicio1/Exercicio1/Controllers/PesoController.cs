using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio1.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exercicio1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PesoController : ControllerBase
    {
        // GET: api/Peso
        [HttpGet]
        public IEnumerable<string> GetPesoObjeto(double Densidade, double VolumeTotal)
        {
            Objeto objeto = new Objeto();
            objeto.Densidade = Densidade;
            objeto.Volume = VolumeTotal;

            return new string[] { "value1", objeto.Peso.ToString() };
        }

    }
}
