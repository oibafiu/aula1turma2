using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDois
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitAppText();

            string nome = string.Empty;
            int idade = 0; 

           
            {
                //podemos enxutar o código
                nome = AskToName();
               

            }
            Console.WriteLine("---------------");
            Console.WriteLine($"Seja bem vindo  {nome} VIVA A VIDA!");
            Console.WriteLine("---------------");
            Console.ReadKey();


        }
       
        private static void ShowInitAppText() 
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Seja bem vindo!");
            Console.WriteLine("---------------");

        }
       
       
        private static string AskToName()
        {
            Console.WriteLine("Qual é o nome dessa Belezinha????");
            return Console.ReadLine();
        }

    }
}

