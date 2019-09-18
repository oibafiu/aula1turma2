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
            MenuSistema();
        }
        private static void MenuSistema()
        {
            Console.WriteLine("Escolha uma das opções do menu:");
            Console.WriteLine("1 - Calculo de área");
            Console.WriteLine("2 - Mostrar animaçã");
            Console.WriteLine("3 - Listar Cervejas da Ambev");
            Console.WriteLine("4 - Listar Carros");
            Console.WriteLine("5 - Sair do sistema");

            var menuEscolhido = int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1: {
                        CalculaArea();
                        MenuSistema();
                    } break;
                case 2: {
                       AnimacoesEmFrame.Part1();
                        MenuSistema();

                    } break;
                case 3:
                    {
                        CervejasLista.CervejaLista();MenuSistema();

                    } break;
                case 4:
                    {
                        ListarCarro.ListaCarro();MenuSistema();
                    } break;
                case 5: {
                        Console.WriteLine("Saindo......");
                        return;
                    } 
                default:
                    break;
            }
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
