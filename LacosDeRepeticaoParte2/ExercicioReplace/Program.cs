using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReplace
{
    class Program
    {
        /// <summary>
        /// Metodo que troca o 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

        }

        private static void IniciandoFor()
        {
            Console.WriteLine("Informe o seu nome");
            var conteudoDoTexto = $"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleção;e;vamos;colocar;isto;{Console.ReadLine()};para;depois;usar;com;o;replace";

            Console.WriteLine("Informe a palavra para realizar a busca");
            var palavra = Console.ReadLine();
            var conteudoTextoSplit = conteudoDoTexto.Split(';');

            foreach (var item in conteudoTextoSplit)
            {
                if (palavra == item)
                    Console.WriteLine("Palavra encontrada com sucesso");


            }
            Console.ReadKey();
        }
    }
}