using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodeBeber
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitAppText();

            while (AskToContinue() >= 18)
            {
                Console.WriteLine("Já pode beber ");
                
            }
        }
        private static void ShowInitAppText() //declaro o texto que será exibido sem poluir o código
        {
            Console.WriteLine("---------------");
            Console.WriteLine("E ai Parça!");
            Console.WriteLine("---------------");

        }
        private static int AskToContinue()
        {
            Console.WriteLine("Que idade você tem? ");
            return int.Parse(Console.ReadLine());
        }
    }
}
