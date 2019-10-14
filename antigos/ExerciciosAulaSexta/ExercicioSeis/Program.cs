using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSeis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um texto que contenha a palavra banana: Obrigatório");
            var texto = Console.ReadLine();
            texto = texto.Replace("banana", "laranja");
            Console.WriteLine(texto);
            Console.ReadKey();
           
        }
    }
}
