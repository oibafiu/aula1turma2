using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace Arvore
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaArea();
        }
        public static void CalculaArea()
        {
            Console.WriteLine("Informa o lado do quadrado");
            var ladoQuadrado = int.Parse(Console.ReadLine());
            var bibliotecaCalculos = new CalculosDeArea();
            Console.WriteLine($"Minha area é {bibliotecaCalculos.CalculaAreaDoQuadrado(ladoQuadrado)}");
            Console.ReadKey();
        }
    }
}
