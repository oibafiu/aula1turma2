using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeiroTexto = "Esse é um teste para fazer uma programação de repetição para teste de programação senodo que" +
                "esse teste é um teste feito por mim teste ";
            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto Contem: {primeiroTexto.Length} caracteres");

            primeiroTexto = primeiroTexto.Replace("teste", "1")
            .Replace("programação", "2").Replace("um","5");
            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto Contem: {primeiroTexto.Length} caracteres");
            //TROCAR DO TEXTO A PALAVRA TESTE POR 1

            primeiroTexto = primeiroTexto.Replace("1","teste")
           .Replace("2","programação").Replace("5", "um");
            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto Contem: {primeiroTexto.Length} caracteres");

            Console.ReadKey();
        }
    }
}
