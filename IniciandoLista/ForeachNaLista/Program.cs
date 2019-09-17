using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListaDateTime();
            // ListaString();
            //ListaNumeros();
            ListaDecimais();

        }
        /// <summary>
        /// Mostra lista de datas definidas
        /// </summary>
        private static void ListaDateTime()
        {
            var minhaLista = new List<DateTime>();

            minhaLista.Add(new DateTime(2019,9,17));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 19));
            minhaLista.Add(new DateTime(2019, 9, 20).AddDays(99));

            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToString("dd/MM/yyyy")));

            Console.ReadKey();
        }
        /// <summary>
        /// Mostra lista de strings definidas
        /// </summary>
        private static void ListaString()
        {
            var minhaLista = new List<string>();
            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE APPLE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");

            //esse código é mais abstrato 
            minhaLista.ForEach(i => Console.WriteLine(i));

           // foreach (var item in minhaLista) //esse foreach é o mesmo que o de cima, apenas com mais linhas. Troca o item pelo (i)
           // {
          //      Console.WriteLine(item);
          //  }

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra os números inteiros
        /// </summary>
        private static void ListaNumeros()
        {
            var minhaLista = new List<int>
            {
                
                
                17,
                18,
                19,
                20
            };

            minhaLista.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();

        }
        /// <summary>
        /// Essa lista mostra os decimais usando double
        /// </summary>
        private static void ListaDecimais()
        {
            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.98);
            minhaLista.Add(2.42);
            minhaLista.Add(0.02);

            minhaLista.ForEach(i => Console.WriteLine(i.ToString("C") + " " + FormataNumeroDecimalBitcoin(i))); //String.Format("{0:C}", i
            Console.ReadKey();
        }

        /// <summary>
        /// metodo que transforma o numero decimal em dolar
        /// </summary>
        /// <param name="meuNumero">retorna o valor formatado</param>
        /// <returns></returns>
        private static string FormataNumeroDecimal(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C3", CultureInfo.CreateSpecificCulture("en-US"));
            
        }
        /// <summary>
        /// metodo que transforma o numero decimal em Iene
        /// </summary>
        /// <param name="meuNumero">meu valor formatado em real</param>
        /// <returns>retorna o valor formatado</returns>
        private static string FormataNumeroDecimalIene(double meuNumero)
        {
            return (meuNumero / 0.038).ToString("C3", CultureInfo.CreateSpecificCulture("ja-JP"));

        }
        /// <summary>
        /// metodo que transforma o numero decimal em Euro
        /// </summary>
        /// <param name="meuNumero">meu valor formatado em real</param>
        /// <returns>retorna o valor formatado</returns>
        private static string FormataNumeroDecimalEuropa(double meuNumero)
        {
            Console.OutputEncoding = Encoding.Default;
            return (meuNumero / 5.0274).ToString("C3", CultureInfo.CreateSpecificCulture("fr-BE"));

        }
        /// <summary>
        /// metodo que transforma o numero decimal em Bitcoin
        /// </summary>
        /// <param name="meuNumero">meu valor formatado em real</param>
        /// <returns>retorna o valor formatado</returns>
        private static string FormataNumeroDecimalBitcoin(double meuNumero)
        {
            return (meuNumero / 42050.00000).ToString("C6", CultureInfo.CreateSpecificCulture("BTC"));

        }
    }
}
