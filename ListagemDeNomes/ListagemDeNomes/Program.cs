using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nomes.Model;
using Nome.Controller;

namespace ListagemDeNomes
{
    class Program
    {
        static PessoaController pessoas = new PessoaController();
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um nome para salvar no banco:");
            var nome = Console.ReadLine();
            var resultado = pessoas.InserirNome(new Pessoas()
            {
                Nome = nome
            });
            
            Console.ReadKey();
        }
    }
}
