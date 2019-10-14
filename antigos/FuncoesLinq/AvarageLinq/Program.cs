using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvarageLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Venda> vendas = new List<Venda>()
            {
                new Venda()
                {
                    Produto = "Xiaomi",
                    Quantidade = 8,
                    Valor = 1200.75
                },
            new Venda()

            {
                Produto = "Slim 3500 APP",
                Quantidade = 5,
                Valor = 2800.96
            },
            new Venda()
            {
                Produto = "Iphone ",
                Quantidade = 1,
                Valor = 9999.99
            }
        };
            Console.WriteLine("Media de produtos vendidos neste mês");
            Console.WriteLine(vendas.Average(i => i.Quantidade).ToString("N2"));
            Console.WriteLine("Media total de vendas nesse mês em R$");
            Console.WriteLine(vendas.Average(i => i.Quantidade * i.Valor).ToString("C2"));
            Console.ReadKey();
        }
    }
}
