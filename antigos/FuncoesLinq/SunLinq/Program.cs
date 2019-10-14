using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            SomarInteiroPrimitivos();
            SomarInteiroLista();
            SomaBalasListaDeCriancas();

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra numeros inteiros por um tipo primtiivo
        /// só pode ser colocado o tamanho alocado na memoria
        /// </summary>
        private static void SomarInteiroPrimitivos()
        {
            //Quando utilizamos "[]" em um tipo primitivo podemos criar uma coleção destes valores
            int[] colecaoInteiros =
                //alocamos memoria para nossa colecao de valores e informamos a quantidade de memoria que vamos ocupar
                new int[5]
                //Aqui carregamos nossa colecao de valores
                {1,2,3,4,5};

            Console.WriteLine(colecaoInteiros.Sum());
        }
        /// <summary>
        /// Nesse caso com o List, podemos adicionar quantos números forem necessários
        /// 
        /// </summary>
        private static void SomarInteiroLista()
        {
            List<int> listaDeInteiros = new List<int>()
            {
                1,2,3,4,5
            };
            Console.WriteLine(listaDeInteiros.Sum());
        }
        /// <summary>
        /// Metodo que soma a quantidade de bala das crianças
        /// </summary>
        private static void SomaBalasListaDeCriancas()
        {
            List<Crianca> criancas = new List<Crianca>()
            {
                new Crianca()
                {
                    Nome = "Joãozinho",
                    Balas = 9
                },
                new Crianca()
                {
                    Nome = "Pedrinho",
                    Balas = 68
                }
            };
            Console.WriteLine("Quantidade total de balas das criancinhas levaram da venda");
            Console.WriteLine(criancas.Sum(i => i.Balas));
        }
    }
}
