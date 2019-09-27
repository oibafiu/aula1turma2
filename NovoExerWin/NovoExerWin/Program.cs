using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;
namespace NovoExerWin
{
    class Program
    {
        static DocumentsAutoGenerate documents = new DocumentsAutoGenerate();
        
        static void Main(string[] args)
        {
            var menu = int.MinValue;

            while (menu != 0)
            {
                Console.Clear();
                Console.WriteLine("Sistema de pasta");
                Console.WriteLine("1 - Criar Pasta em meus documentos");
                Console.WriteLine("0 -  Sair");

                menu = int.Parse(Console.ReadLine());
            }

            switch (menu)
            {
                case 1:
                    new HoraDoShow.
                    break;
            }
            
            
            Console.ReadKey();
        }
    }
}
