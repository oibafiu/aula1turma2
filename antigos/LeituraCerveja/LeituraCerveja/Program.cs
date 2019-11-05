using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;
namespace LeituraCerveja
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {

            cervejaController.CadastrarCervejas(new Cerveja()

            {
                Id = cervejaController.GetCervejas().Count + 1,
                Nome = "Giomar",
                Litros = 0.600,
                Alcool = 7.5,
                Valor = 0.98
            });
            cervejaController.GetCervejas().ForEach(i => Console.WriteLine($"{i.Id} {i.Nome} {i.Valor} {i.Litros} {i.Alcool}"));


            Console.WriteLine("Total litros" + cervejaController.ListaSomaLitros());
            Console.ReadKey();
        }
    }
}
