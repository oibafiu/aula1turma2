using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitAppText();

            string nome = string.Empty;
            int idade = 0;
            

            
            //keychar é o botão que você clica no teclado
            //readkey lê qual o botão você clicou
            //ToString transforma em uma string que pode ser "lida" pelo usuário
           
            //Parse converte um numero inteiro em uma string < vice e versa
            while (AskToContinue() == 1)
            {
                //podemos enxutar o código
                nome = AskToName();
                idade = AskToAge(nome);

            }
            Console.WriteLine($"Suas informações: Nome: {nome} e sua Idade: {idade}");
            Console.ReadKey();
  

        }
        /// <summary>
        /// Metodo para mostrar o texto inicial do sistema 
        /// </summary>
        private static void ShowInitAppText() //declaro o texto que será exibido sem poluir o código
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Seja bem vindo!");
            Console.WriteLine("---------------");

        }
        /// <summary>
        /// Metodo para realizar a pergunta se deseja continuar
        /// </summary>
        /// <returns>retorna o valor que foi inserido</returns>
        private static int AskToContinue()
        {
            Console.WriteLine("Vamos conversar? (1) sim (2) não");
            return int.Parse(Console.ReadKey().KeyChar.ToString());
        }
        private static int AskToAge(string nome) //posso chamar a variavel nome dentro do age
        {
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine($"{nome} Já pode beber");
            else
                Console.WriteLine($"{nome} Não pode");
        
            return idade;
        }
        /// <summary>
        /// Metodo para perguntar o nome
        /// </summary>
        /// <returns>retorna o nome informado</returns>
        private static string AskToName()
        {
            Console.WriteLine("Qual seu nome?");
            return Console.ReadLine();
        }
            
    }
}
