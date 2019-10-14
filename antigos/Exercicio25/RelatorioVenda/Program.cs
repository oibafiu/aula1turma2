using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RelatorioVenda
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public static void MostraMenuSistema()
        {

            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Venda de Carro ");

                Console.WriteLine("----- Menu Sistema -----");
                Console.WriteLine("1 - Listar Vendas");
                Console.WriteLine("2 - Relatorio de vendas por mês");
                Console.WriteLine("0 - Sair");

                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                //Executar proxima funcao
                switch (menuEscolhido)
                {
                    case 1:
                        ListarVendas();
                        break;
                    case 2:
                       
                        break;
                    default:
                        break;
                }
            }

        }
        public static void ListarVendas()
        {
            
        }

    }
}
