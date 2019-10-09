using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Controller;
using CatalogoCelulares.Model;

namespace CellDu
{
    class Program
    {
        //1 - Colocar console app para startar projeto
        //2 - Adicionar referencia catalogocelulares
        //3 - Adicionar enttity em nosso projeto
        //4 - Adicionar using ao nosso projeto Model, Controller 

        static CelularesController celulares = new CelularesController();
        static void Main(string[] args)
        {
            var opcao = int.MinValue;

            while (opcao != 0)
            {
                Console.WriteLine("Escolha um menu");
                Console.WriteLine("1 - Inserir Celular");
                Console.WriteLine("2 - Atualizar Celular");
                Console.WriteLine("3 - Remover Celular");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        InserirCelular();
                        break;
                    case 2:
                        AtualizarCelular();
                        break;
                    case 3:
                        RemoverCelular();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do sistema.......");
                        break;
                }
            }
            Console.ReadKey(true);
        }
        public static void InserirCelular()
        {
            Console.WriteLine("---Inserir Celular---");
            Console.WriteLine("Informe a marca do Celular");

            var marca = Console.ReadLine();

            Console.WriteLine("Informe o modelo do celular");

            var modelo = Console.ReadLine();

            Console.WriteLine("Informe o valor do aparelho");

            var preco = double.Parse(Console.ReadLine());



            var resultado = celulares.InserirCelular(new Celular()
            {
                Marca = marca,
                Modelo = modelo,
                Preco = preco
            });
            if (resultado)
                Console.WriteLine("Celular cadastrado com sucesso");
            else
                Console.WriteLine("Erro ao cadastrar aparelho");
        }

        public static void AtualizarCelular()
        {
            Console.WriteLine("---Atualizar Celular---");
            ListarCelular();
            Console.WriteLine("Informe o Id para alteração de registro");
            var celularId = int.Parse(Console.ReadLine());

            var celular = celulares.GetCelulares().FirstOrDefault(i => i.Id == celularId);

            if (celular == null)
            {
                Console.WriteLine("Id informado inválido");
                return;
            }
                
            Console.WriteLine("Informe a marca do Celular");

            celular.Marca = Console.ReadLine();

            Console.WriteLine("Informe o modelo do celular");

           celular.Modelo = Console.ReadLine();

            Console.WriteLine("Informe o valor do aparelho");

            celular.Preco = double.Parse(Console.ReadLine());



            var resultado = celulares.AtualizarCelular(celular);
            
            if (resultado)
                Console.WriteLine("Celular atualizado com sucesso");
            else
                Console.WriteLine("Erro ao atualizar aparelho");
        }

        public static void RemoverCelular()
        {
            Console.WriteLine("---Remover Celular---");
            celulares.GetCelulares().ToList<Celular>().ForEach(i => Console.WriteLine($"Id:{i.Id}\r\n Marca: {i.Marca}\r\n Modelo: {i.Modelo}\r\n Preço: {i.Preco}"));

            Console.WriteLine("Informe o Id para remover o celular do registro");
            var celularId = int.Parse(Console.ReadLine());


            var resultado = celulares.RemoverCelular(celularId);
            if (resultado)
                Console.WriteLine("Celular removido com sucesso");
            else
                Console.WriteLine("Erro ao remover aparelho");

           
        }
    public static void ListarCelular()
        {
            Console.WriteLine("----Listar Celular----");

            celulares.GetCelulares().ToList<Celular>().ForEach
                (i => Console.WriteLine($"Id:{i.Id}\r\n Marca: {i.Marca}\r\n Modelo: {i.Modelo}\r\n Preço: {i.Preco}"));
        }
    }
}
