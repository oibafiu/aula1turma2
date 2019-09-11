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
            

            string testePrimitivo = string.Empty;
            String outroTestePrimitivo = string.Empty;
            bool testComp;
            Boolean testeComp;

            bool? testeBoolNull;
            long numeroInteiroLongo = 9859959;

            var testeFora = string.Empty;
            testeFora = "teste";


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
