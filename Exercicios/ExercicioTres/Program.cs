using ExercicioTres.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            var cadastroVeiculo = new List<Veiculos>();

            var veiculo = new Veiculos();

            Console.WriteLine("Digite o modelo do veículo:");
            veiculo.Modelo = Console.ReadLine();
            Console.WriteLine("Digite a marca do veículo:");
            veiculo.Marca = Console.ReadLine();
            Console.WriteLine("Digite o ano do veículo:");
            veiculo.Ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do veículo:");
            veiculo.Valor = double.Parse(Console.ReadLine());

            cadastroVeiculo.Add(veiculo);

            Console.WriteLine("\r\n---------------------------------------------\r\n");

            

            cadastroVeiculo.ForEach(i => Console.WriteLine($"Modelo: {i.Modelo}\r\n" +
                $"Marca: {i.Marca}\r\n" +
                $"Ano: {i.Ano}\r\n" +
                $"Valor: {i.Valor}\r\n"));
            



            Console.WriteLine("Deseja Cadastrar mais alguém? (1) Sim (2) Não");
            Console.ReadLine();
            Console.ReadKey();
        }
        
            
        }
        
    }

