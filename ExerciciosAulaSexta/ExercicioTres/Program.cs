using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitAppText();

            string nome = string.Empty;
            int idade = 0;
            
            {
                
                nome = AskToName();
                idade = AskToAge(nome);
                Console.WriteLine("\r\nDigite qualquer tecla para sair");

            }
            
            Console.ReadKey();
        }
       
        private static void ShowInitAppText() 
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Seja bem vindo!");
            Console.WriteLine("---------------");

        }
       
        private static int AskToAge(string nome) 
        {
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine($"Parabéns > {nome} < você já está na vida adulta!!!");
            else
                Console.WriteLine($"Calma > {nome} <  tudo ao seu tempo logo você terá 18 anos de idade.");

            return idade;
        }
        
        private static string AskToName()
        {
            Console.WriteLine("Qual seu nome?");
            return Console.ReadLine();
        }

    }
}

