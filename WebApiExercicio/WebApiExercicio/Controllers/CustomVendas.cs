using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiExercicio.Models;

namespace WebApiExercicio.Controllers
{
    [RoutePrefix("Api/Reports")]
    public partial class CustomVendas : ApiController
    {
        Context db = new Context();


        [HttpGet]
        [Route("{ano}")]
        public object RelVendasAno(int ano)
        {
            var listaVendas = db.Vendas.Where(i => i.DatInc.Year == ano).ToList();

            var listaCarros = db.Carros.ToList();

            var conteudoRetorno = from vendas in listaVendas
                                  join carros in listaCarros
                                  on vendas.Carro equals carros.Id
                                  select new
                                  {
                                      vendas.Id,
                                      Carro = carros.Modelo,
                                      vendas.Quantidade,
                                      vendas.Valor,
                                      Total = (vendas.Quantidade * vendas.Valor).ToString("N2")
                                  };

            return conteudoRetorno;
        }
        public object RelAnoUsuario(int ano, int usuario)
        {
            var listaUsuarios = db.Usuarios.ToList();
            var listaVendas = db.Vendas.Where(i => i.DatInc.Year == ano && i.UsuInc == usuario).ToList();
            var listaCarros = db.Carros.ToList();


            var retornoConteudo = from vendas in listaVendas
                                  join carros in listaCarros on vendas.Carro equals carros.Id
                                  join
usuarios in listaUsuarios on vendas.UsuInc equals usuarios.Id
                                  select new
                                  {
                                      vendas.Id,
                                      Carro = carros.Modelo,
                                      Nome = usuarios.Usuario1,
                                      vendas.Quantidade,

                                  };

            return listaVendas;
        }
        [HttpGet]
        [Route("/ByMarcas/{ano}/{marca}")]
        public object RelAnoMarca(int ano, int marca)
        {
            var listaVendas = db.Vendas.Where(i => i.DatAlt.Year == ano).ToList();
            var listaCarros = db.Carros.Where(i => i.Marca == marca).ToList();
            var listaMarcas = db.Marcas.ToList();

            var conteudoRetorno = from ven in listaVendas
                                  join car in listaCarros
                                  on ven.Carro equals car.Id
                                  join mar in listaMarcas
                                  on car.Marca equals mar.Id
                                  group new { ven, car, mar }
                                  by new { ven.DatInc.Month, mar.Nome }
                                  into ingroup
                                  select new
                                  {
                                      PeriodoVenda = ingroup.Key.Month,
                                      MarcaVenda = ingroup.Key.Nome,
                                      ValorTotalVendas = ingroup.Sum(i => i.ven.Quantidade * i.ven.Valor)

                                  };

            return conteudoRetorno.OrderByDescending(i => i.ValorTotalVendas);




        }
    }
}