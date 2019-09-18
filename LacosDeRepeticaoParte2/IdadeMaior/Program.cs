using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(ForeachComSplitLista());
            Console.ReadKey();
        }
        private static string ForeachComSplitLista()
        {
            string retorno = "";
            var conteudo =
                "nome:Felipe,idade: 27; nome: Giomar,idade: 17; nome: Edson,idade: 19; nome: Ericledson,idade: 75; nome: Junior,idade: 45";
            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("Usuários maiores de idade:");

            foreach (var item in listaDeInformacoes)
            {
                var informacoesSplit = item.Split(',');
                var nome = informacoesSplit[0].Split(':')[1];
                int idade = int.Parse(informacoesSplit[1].Split(':')[1]);


                if(idade >= 18)
                
                {
                    retorno += nome + ",";
                }
                
            }
            return retorno;
        }

    }
}