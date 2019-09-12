using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informa a palavra de busca");
            var wordCount = FindByWhile(Console.ReadLine());

            Console.WriteLine($"Encontrados:{wordCount}");
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo para buscar a palavra por while
        /// </summary>
        /// <param name="wordFind">Palavra com 3 caracteres</param>
        /// <returns>retorna a quantidade encontrada dentro do texto</returns>
        private static int FindByWhile(string wordFind)
        {
            var contentToFind = TextContent();
            var wordFindCountLength = wordFind.Length;
            var lengthText = contentToFind.Length - wordFindCountLength;
            var contWordFind = 0;
            var i = 0;

            while ( i < lengthText)
            {
                var compareWord = contentToFind[i].ToString() +
                                   contentToFind[i + 1].ToString() +
                                   contentToFind[i + 2].ToString();


                if (wordFind == compareWord)
                    contWordFind++;

                i++;
            }
            return contWordFind;
        }
        public static string TextContent()
        {
            return "";
        }
    }
            
    }

