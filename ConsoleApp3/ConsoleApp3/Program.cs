using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe uma sequencia de numeros");
            var textContent = Console.ReadLine();

            Console.WriteLine(textContent.Replace("3", "Banana"));
            Console.ReadKey(); //QUANDO DIGITAR NUMEROS 3 SERÁ SUBSTITUIDO PARA BANANA 
        }
    }
}
