using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Texto para consultar o livro
            Console.Write("Informe o livro a ser consultado:");
            //Parte do codigo que recebe as informações
            var numeroDoLivro = Console.ReadLine();
            //Comparação das informações do livro informado
            if (numeroDoLivro == "123456")
            {
                Console.WriteLine("Livro Indisponível");
                Console.ReadKey();
                return;

            }
            else
            {
                Console.WriteLine("Deseja alocar o livro? (1) sim (2) não");
                var resposta = Console.ReadLine();
                if (resposta == "1") ;
                {
                    Console.WriteLine("Livro alocado");
                    Console.ReadKey();
                    return;
                }

            }
            

        }
    }
}
