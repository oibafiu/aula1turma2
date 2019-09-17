using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema conversor de moedas");
            Console.WriteLine("Informe um valor a ser convertido:");

            var valorASerConvertido = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe uma moeda para conversão");
            Console.WriteLine("DOLAR, EURO, YEN, BTC");

            var moedaAlvoParaConverter = Console.ReadLine();

            ConvertMoeda(valorASerConvertido, moedaAlvoParaConverter);

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que converte moeda em real para um alvo especificado
        /// para converter digite os alvos:
        /// "EURO"
        /// "YEN"
        /// "BTC"
        /// "DOLAR"
        /// </summary>
        /// <param name="minhaMoeda">Moeda em valor real</param>
        /// <param name="moedaAlvo">Moeda a ser convertida</param>
        public static void ConvertMoeda(double minhaMoeda,string moedaAlvo)
        {
            switch (moedaAlvo)
            {
                case "DOLAR":
                Console.WriteLine(FormataNumeroDecimal(minhaMoeda));
                    break;
                case "EURO":
            
                Console.WriteLine(FormataNumeroDecimalEuropa(minhaMoeda));
                    break;
                case "BTC":
                Console.WriteLine(FormataNumeroDecimalBitcoin(minhaMoeda));
                    break;
                case "YEN":
                    Console.WriteLine(FormataNumeroDecimalIene(minhaMoeda));
                    break;
            
        
                default:
                    break;
            }
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
        /// <summary>
        /// metodo que transforma o numero decimal em Iene
        /// </summary>
        /// <param name="meuNumero">meu valor formatado em real</param>
        /// <returns>retorna o valor formatado</returns>
        private static string FormataNumeroDecimalIene(double meuNumero)
        {
            return (meuNumero / 0.038).ToString("C3", CultureInfo.CreateSpecificCulture("ja-JP"));

        }
    }
}
