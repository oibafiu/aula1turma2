using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;


namespace SistemaCervejaAmbebe
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();

        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Cerveja HãBébe?");
            Console.WriteLine("1 - Valor total das cervejas e quantidade de litros");
            Console.WriteLine("2 - Listar cervejas");
            Console.WriteLine("3 - Adicionar Cervejas");
            Console.WriteLine("0 - Sair");
            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)
            {
                menuEscolhido = int.Parse(Console.ReadLine());

                switch (menuEscolhido)
                {
                    case 1:
                        {
                            cervejaController.ListarInformacoes();
                        }
                        break;
                    case 2:
                        {

                            cervejaController.GetCerveja().ForEach(i => Console.WriteLine($"Cervejas: {i.Nome}"));
                        }
                        break;
                    case 3:
                        {

                          AdicionarCerveja();
                        }
                        break;


                }

            }
        }
        private static void AdicionarCerveja()
        {
            Console.WriteLine("Cadastrar cerveja");
            Console.WriteLine("Informe o nome da cerveja");
            var cerveja = Console.ReadLine();


            Console.WriteLine("Informe o volume");
            var volume = double.Parse(Console.ReadLine());
            cervejaController.AdicionarCerveja(new Cerveja()
            {
                Nome = cerveja,
                Litros = volume
            });
            Console.WriteLine("Cerveja cadastrada com sucesso!");
            Console.ReadKey();
        }


    }
}

