using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
    public class SistemaCarrosContext
    {
        public List<Carro> ListaDeCarro { get; set; }

        public SistemaCarrosContext()
        {
            ListaDeCarro = new List<Carro>();

            ListaDeCarro.Add(new Carro()
            { Id = 1, Marca = "Volksvagem", Modelo = "Gol", Ano = 2015, Clilindradas = 1000, Portas = 4});
            ListaDeCarro.Add(new Carro()
            { Id = 2, Marca = "CHANA", Modelo = "Utility Furg", Ano = 2005, Clilindradas = 1000, Portas = 2 });
            ListaDeCarro.Add(new Carro()
            { Id = 3, Marca = "FOTON", Modelo = "AUMARK", Ano = 2014, Clilindradas = 3500, Portas = 4 });
            ListaDeCarro.Add(new Carro()
            { Id = 4, Marca = "Cadillac", Modelo = "Seville 4.6", Ano = 1991, Clilindradas = 2000, Portas = 2 });
            ListaDeCarro.Add(new Carro()
            { Id = 5, Marca = "Fiat", Modelo = "Fiorino Furg", Ano = 1992, Clilindradas = 1000, Portas = 3 });
            ListaDeCarro.Add(new Carro()
            { Id = 6, Marca = "Fibravan", Modelo = "Buggy Vip", Ano = 2007, Clilindradas = 1600, Portas = 2 });
            ListaDeCarro.Add(new Carro()
            { Id = 7, Marca = "Jeep", Modelo = "Wrangler SAHARA", Ano = 2011, Clilindradas = 2000, Portas = 4 });
            ListaDeCarro.Add(new Carro()
            { Id = 8, Marca = "Ferrari", Modelo = "F458 Italia", Ano = 2011, Clilindradas = 4499, Portas = 2 });
            ListaDeCarro.Add(new Carro()
            { Id = 9, Marca = "Hyundai", Modelo = "Sonata", Ano = 1999, Clilindradas = 1500, Portas = 4 });
            ListaDeCarro.Add(new Carro()
            { Id = 10, Marca = "BMW", Modelo = "X4 XDRIVE", Ano = 2015, Clilindradas = 3000, Portas = 4 });
        }
    }
}
