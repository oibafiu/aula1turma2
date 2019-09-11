using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTypesConcat
{
    class Program
    {
        static void Main(string[] args)
        {
           var teste = @"alguma coisa mais 
alguma informaçao aqui";

            var teste1 = Console.ReadLine();
            var teste2 = Console.ReadLine();
            var teste3 = teste1 + "\r\n" + teste2;

            var testeTemplate = @"Nome do usuario:{0}
Idade:{1}
Descrição:{2}";

            var finishText = string.Format(testeTemplate
                , Console.ReadLine()
                , Console.ReadLine()
                , Console.ReadLine());

            Console.WriteLine(finishText);


            //Console.WriteLine(teste3);
            Console.ReadKey();
        }
    }
}
