using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContext
    {
        public List<Cerveja> ListaDeCerveja { get; set; }

        public SistemaCervejaContext()
        {
            ListaDeCerveja = new List<Cerveja>();

            ListaDeCerveja.Add(new Cerveja()
            { Id = 1, Nome = "Patagonia", Litros = 1.5, Alcool = 4.5, Valor = 30.00 });
            ListaDeCerveja.Add(new Cerveja()
            { Id = 2, Nome = "Brahma Lata", Litros = 0.290, Alcool = 2.5, Valor = 1.99 });
            ListaDeCerveja.Add(new Cerveja()
            { Id = 3, Nome = "Corona", Litros = 0.355, Alcool = 4.5, Valor = 29.94 });
            ListaDeCerveja.Add(new Cerveja()
            { Id = 4, Nome = "Skol Puro Malte", Litros = 0.269, Alcool = 4.4, Valor = 37.35 });
            ListaDeCerveja.Add(new Cerveja()
            { Id = 5, Nome = "Budweiser", Litros = 0.350, Alcool = 5.0, Valor = 33.48 });

        }
    }
}

    

