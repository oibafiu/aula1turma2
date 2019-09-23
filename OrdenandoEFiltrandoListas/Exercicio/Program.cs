using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaPessoas = new List<Pessoas>();


            listaPessoas.Add(new Pessoas()
            {
                Id = 1 ,
                Nome = "Spears",
                DataNascimento = DateTime.Parse("07/11/2004"),
                Carteira = 846.96
            });
            listaPessoas.Add(new Pessoas()
            {
                Id = 2,
                Nome = "Swanson",
                DataNascimento  = DateTime.Parse("20/06/2003"),
                Carteira =233.09
            });
            
            listaPessoas.Add(new Pessoas()
            {
                Id = 3,
                Nome = "Gay",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 911.92
            });
            listaPessoas.Add(new Pessoas()
            {
                Id = 4,
                Nome = "Gregory",
                DataNascimento = DateTime.Parse("02/01/2000"),
                Carteira = 469.01
            });
            listaPessoas.Add(new Pessoas()
            {
                Id = 5,
                Nome = "Olson",
                DataNascimento = DateTime.Parse("18/07/2001"),
                Carteira = 261.90
            });
            listaPessoas.Add(new Pessoas()
            {
                Id = 6,
                Nome = "Garza",
                DataNascimento = DateTime.Parse("01/04/2000"),
                Carteira = 360.41
            });
            listaPessoas.Add(new Pessoas()
            {
                Id = 7,
                Nome = "Sweet",
                DataNascimento = DateTime.Parse("12/03/2003"),
                Carteira = 312.76
            });
            listaPessoas.Add(new Pessoas()
            {
                Id = 8,
                Nome = "Cline",
                DataNascimento = DateTime.Parse("26/03/2003"),
                Carteira = 484.71
            });
            listaPessoas.Add(new Pessoas()
            {
                Id = 9,
                Nome = "Oliver",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 513.76
            });
            listaPessoas.Add(new Pessoas()
            {
                Id = 10,
                Nome = "Vang",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 271.05
            });
            listaPessoas.Add(new Pessoas()
            {
                Id = 11,
                Nome = "Maddox",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 783.97
            });
            listaPessoas.Add(new Pessoas()
            {
                Id = 12,
                Nome = "Garret",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 154.11
            });
            listaPessoas.Add(new Pessoas()
            {
                Id = 13,
                Nome = "Mcintosh",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 902.80
            });
            listaPessoas.Add(new Pessoas()
            {
                Id = 14,
                Nome = "Yang",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 550.48
            });
            listaPessoas.Add(new Pessoas()
            {
                Id = 15,
                Nome = "Hendricks",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 410.56
            });
            listaPessoas.Add(new Pessoas()
            {
                Id = 16,
                Nome = "Cain",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 221.13
            });
            listaPessoas.Add(new Pessoas()
            {
                Id = 17,
                Nome = "Blackburn",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 135.67
            });
            listaPessoas.Add(new Pessoas()
            {
                Id = 18,
                Nome = "Howe",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 360.14
            });
            listaPessoas.Add(new Pessoas()
            {
                Id = 19,
                Nome = "Pratt",
                DataNascimento = DateTime.Parse("18/08/2000"),
                Carteira = 991.83
            });
            listaPessoas.Add(new Pessoas()
            {
                Id = 20,
                Nome = "Sherman",
                DataNascimento = DateTime.Parse("20/02/2003"),
                Carteira = 667.00
            });
             

            Console.WriteLine("Pessoas listadas por ordem crescente de nome\r\n");
            listaPessoas.OrderBy(i => i.Nome).ToList<Pessoas>().ForEach(i => Console.WriteLine($"Id = {i.Id}\r\nNome = {i.Nome}\r\n"));

            Console.WriteLine("------------------------------------\r\n");
            Console.WriteLine("Pessoas listas por ordem decrescente de nascimento\r\n");

            listaPessoas.OrderByDescending(i => i.DataNascimento).ToList<Pessoas>().ForEach(i => Console.WriteLine($"ID = {i.Id}\r\nNome = {i.Nome}\r\nData de Nascimento = {i.DataNascimento.ToString("MM/dd/yyyy")} \r\n"));


            (from gente in listaPessoas //-> aqui temos a coleção de frutas
             where gente.Carteira > 500.00 //<- 
             select gente).ToList<Pessoas>().ForEach(i => Console.WriteLine($"Nome = { i.Nome}\r\nDinheiro = {i.Carteira}"));

            listaPessoas.FindAll(i => (DateTime.Now.Year - i.DataNascimento.Year) <= 16);
            
            Console.ReadKey();

            
        }
    }
}
