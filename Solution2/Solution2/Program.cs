using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informar o nome a ser calculado");
            var nomeLength = Console.ReadLine();

            Console.WriteLine($"O tamanho desse nome é: " +
                $"{nomeLength.Replace(" ", "").Length}");

                
                Console.ReadKey();
        }
    }
}
