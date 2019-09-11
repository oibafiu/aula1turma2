using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        const int testeConst = 999;


        static void Main(string[] args)
        {
            var testeFora;
            testeFora = "teste";

            string testePrimitivo = string.Empty;
            String outroTestePrimitivo = string.Empty;
            bool testComp = "123" == "123";
            Boolean testeComp = "123" == "123";

            var teste1 = "String"; //Texto
            var teste2 = 'C'; //Char
            var teste3 = 0; //Int
            var teste4 = 0.0; //Double
            var teste5 = 0x00; //hex

            Console.WriteLine(testeConst);
            Console.ReadKey();
        }
    }
}
