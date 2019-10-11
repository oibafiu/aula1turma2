using ListagemDeFlores.Controller;
using ListagemDeFlores.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloriculturaInterface
{
    class Program
    {
        static FloresController flores = new FloresController();
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {


            var opcao = int.MinValue;

            while (opcao != 0)
            {
                Console.WriteLine("----------Floricultura----------");
                Console.WriteLine("1 - Inserir Flores");
                Console.WriteLine("2 - Listar Flores");
                Console.WriteLine("2 - Calculadora de flores");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        InserirFlores();
                        break;
                    case 2:
                        ListarFlor();
                        break;
                }
                Console.ReadKey(true);
            }
        }
            public static void InserirFlores()
            {
            
            Console.WriteLine(@"-----------Inserir Flores---------
         _(#)_
         (#(#)#)
         . . .(#)\
. . . . . . | __
. . . . . . |/#/
. . . . . . |
. . . . . . |

");
            Console.WriteLine("Digite o nome da flor:");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade:");
            var quantidade = int.Parse(Console.ReadLine());

            var resultado = flores.InserirFlores(new Flores()
                {
                Nome = nome,
                Quantidade = quantidade,
            });
            if (resultado)
                Console.WriteLine("Flor cadastrada com sucesso");
            else
                Console.WriteLine("Erro ao cadastrar flor");
        
            }
        public static void ListarFlor()
        {
            // flores.GetFlores().ToList<Flores>().ForEach
            //(i => Console.WriteLine($"Id:{i.Id}\r\n Nome: {i.Nome}\r\n Quantidade: {i.Quantidade}"));
            flores.GetFlores().OrderByDescending(i => i.Quantidade).ToList().ForEach(i => Console.WriteLine($"Id:{i.Id}\r\n Nome: {i.Nome}\r\n Quantidade: {i.Quantidade}"));

            Console.WriteLine($"Resultado soma é {flores.GetFlores().Sum(i => i.Quantidade)}");

            



        }
    }
    }

