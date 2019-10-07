using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alunos.Model;
using Alunos.Controller;

namespace ListandoAlunos
{
    class Program
    {
        static AlunoController aluno = new AlunoController();
        static void Main(string[] args)
        {
            MenuInterativo();
           


        }

        public static void AdicionarAlunosBD()
        {
            aluno.AddAluno(new Aluno() { Nome = "Ariosvaldo Pereira" });
            aluno.AddAluno(new Aluno() { Nome = "Juvercino Fagundes" });
            aluno.AddAluno(new Aluno() { Nome = "Aristoteles de Ramos" });
            aluno.AddAluno(new Aluno() { Nome = "Michael Jacson da Silva" });
            aluno.AddAluno(new Aluno() { Nome = "Sandy Junior de Oliveira" });
           
            
        }
        public static void MenuInterativo()
        {
            var menuEscolhido = int.MinValue;
            Console.WriteLine("-------Menu--------");
            Console.WriteLine("1 - Listar Alunos");
            Console.WriteLine("2 - Adicionar Aluno");
            Console.WriteLine("3 - Sair");

            menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());
            switch(menuEscolhido)
            {
                case 1:
                    {
                        ListarAlunos();
                        MenuInterativo();
                    }break;
                case 2:
                    {
                        AdicionarAluno();
                    }break;
                case 3:
                    {
                        Console.WriteLine("Digite enter 2x para sair");
                        Console.ReadKey();
                    }
                    break;

            }
            Console.ReadKey();
        }
        public static void AdicionarAluno()
        {
            Console.WriteLine("Digite o nome do aluno:");
            aluno.AddAluno(new Aluno() { Nome = Console.ReadLine() });
            MenuInterativo();


        }
           
        public static void ListarAlunos()
        {
            Console.WriteLine("--------Lista de Alunos------");
            aluno.GetAlunos().ToList<Aluno>().ForEach(i => Console.WriteLine(i.Nome));
         
            Console.ReadKey();
        }


    }
    
}
