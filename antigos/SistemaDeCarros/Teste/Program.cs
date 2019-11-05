using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;
using ListagemDeCarros.Controller;


namespace Teste
{
    
    class Program
    {
        static CarroController carrosController = new CarroController();
        static void Main(string[] args)
        {
            ImprimeInformacoes();
            Console.ReadKey();
        }
        public static void ImprimeInformacoes(Carro carros)
        {
            Console.WriteLine(string.Format("Id = {0,1} Marca = {1,-20} Modelo {2,-10} Ano {3,3} Cilindradas {4,12} Portas {4,12}",
                carros.Id,
                carros.Marca,
                carros.Modelo,
                carros.Ano,
                carros.Clilindradas,
                carros.Portas));
        }
       

    }     
}
