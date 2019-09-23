using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestoDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cestaDeFrutas = new List<Frutas>();

            //vamos no mercado
            cestaDeFrutas.Add(new Frutas()
            {
                ID = 2,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 212
            });
            cestaDeFrutas.Add(new Frutas()
            {
                ID = 0,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95
            });
            cestaDeFrutas.Add(new Frutas()
            {
                ID = 1,
                Nome = "Manga",
                Cor = "Amarelo",
                Peso = 300
            });

            //Ordem Decrescente
            cestaDeFrutas.OrderByDescending(i => i.ID).ToList<Frutas>().ForEach(i => Console.WriteLine($"{i.ID} Nome: {i.Nome} Peso: {i.Peso}"));

            Console.WriteLine("----------------------------------------");
            //Ordem crescente
            #region Lista 1
            cestaDeFrutas.OrderBy(i => i.ID).ToList<Frutas>().ForEach(i => Console.WriteLine($"{i.ID} Nome: {i.Nome} Peso = {i.Peso}"));
            #endregion
            Console.WriteLine("----------------------------------------");
            //Por peso maiores que 100gramams
            var filtroCesta = cestaDeFrutas.Where(i => i.Peso > 100);

            filtroCesta.ToList<Frutas>().ForEach(i => Console.WriteLine($"ID = {i.ID} Nome = {i.Nome} Peso = {i.Peso}"));

(from frutinha in cestaDeFrutas //-> aqui temos a coleção de frutas
                              where frutinha.Peso > 100 //<- 
                              select frutinha).ToList<Frutas>().ForEach(i => Console.WriteLine($"Fruta escolhida { i.Nome}"));

            var mostrandoFind = cestaDeFrutas.Find(i => i.Cor == "Amarela" || i.Cor == "Vermelho");
            Console.WriteLine($"ID {mostrandoFind.ID} Nome {mostrandoFind.Nome}");

            var mostrandoFindAll = cestaDeFrutas.FindAll(i => i.Cor == "Amarela" || i.Cor == "Vermelho");

            mostrandoFindAll.ForEach(i => Console.WriteLine($"ID {i.ID} Nome {i.Nome}"));

            var listaOrdenada = mostrandoFindAll.OrderBy(i => i.Nome);

            foreach (var i in listaOrdenada)
                Console.WriteLine($"ID {i.ID} Nome: {i.Nome}");


            var cestaDeFrutasFindOrder = cestaDeFrutas.OrderBy(i => i.Nome).ToList<Frutas>().Find(i => i.Cor == "Amarelo" ||
            i.Cor == "Vermelho");
            
            Console.ReadKey();

        }
    }
}
