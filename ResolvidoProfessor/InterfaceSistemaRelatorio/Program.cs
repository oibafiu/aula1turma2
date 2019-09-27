using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Controller;
using SistemaRelatorioCarros.Model;

namespace InterfaceSistemaRelatorio
{
    class Program
    {
        static VendasController vendasController = new VendasController();
        static void Main(string[] args)
        {
            MostraMenuRelatorio();
            //Console.WriteLine("Informações das vendas realizadas durante o ano de 2019");
            //vendasController.GetVendas().ForEach(i => ImprimeInformacoes(i));

            Console.ReadKey();
        }
        private static void MostraMenuRelatorio()
        {
            Console.Clear();
            Console.WriteLine("Menu de relatorios");
            Console.WriteLine("1 - Relatorio por período mensal");
            Console.WriteLine("0 - Sair");
            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)
            {
                menuEscolhido = int.Parse(Console.ReadLine());

                switch (menuEscolhido)
                {
                    case 1:
                        {
                            Console.WriteLine("Informe o mês para realizar o filtro");
                            var mesEscolhido = int.Parse(Console.ReadLine());

                            var listaDoPeriodoEscolhido = vendasController.GetVendas(mesEscolhido);
                            
                           listaDoPeriodoEscolhido.ForEach(i => ImprimeInformacoes(i));

                            var totalMes = vendasController.GetVendas(mesEscolhido).Sum(i => i.Valor * i.Quantidade);

                            var mediaPeriodo = listaDoPeriodoEscolhido.Average(i => i.Valor * i.Quantidade);


                            Console.WriteLine($"Total do mês {mesEscolhido} é {totalMes.ToString("C")}");
                            Console.WriteLine($"Total do mês {mesEscolhido} é {mediaPeriodo.ToString("C")}");
                        }
                        break;
                    default:
                        break;
                }
                
            }
        }
        public static void ImprimeInformacoes(Venda vendas)
        {
            Console.WriteLine(string.Format("Id = {0,1} Carro = {1,-20} Valor {2,-10} Quantidade {3,3} Data {4,12}",
                vendas.Id, 
                vendas.Carro, 
                vendas.Valor.ToString("C2"),
                vendas.Quantidade,
                vendas.Data.ToShortDateString()));
        }
    }
}
