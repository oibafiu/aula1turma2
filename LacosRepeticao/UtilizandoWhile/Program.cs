using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            while (count < 10000000) 
            {
                Console.WriteLine($"Numero:{count}");
                count++;
                //+=5 conta de 5 em 5
            }
            Console.WriteLine("Terminou o Loop");
            Console.ReadKey();
        }
    }
}
