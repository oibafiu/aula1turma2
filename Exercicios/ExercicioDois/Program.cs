using ExercicioDois.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDois
{
    class Program
    {
         static List<Pessoa> cadastroPessoa = new List<Pessoa>();

        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa p1 = new Pessoa();
            p1.Nome = "Gabriel";
            p1.Sexo = 'M';
            p1.Altura = 2.01;
            p1.Idade = 29;

            pessoas.Add(p1);
            Pessoa p2 = new Pessoa();
            p2.Nome = "Elora";
            p2.Sexo = 'F';
            p2.Altura = 1.53;
            p2.Idade = 21;

            pessoas.Add(p2);

            Pessoa p3 = new Pessoa();
            p3.Nome = "Ronaldo";
            p3.Sexo = 'M';
            p3.Altura = 1.53;
            p3.Idade = 16;

            pessoas.Add(p3);

            List<Pessoa> menoresIdade = new List<Pessoa>();

            foreach  (Pessoa p in pessoas)
            {
                if (p.Idade < 18)
                {
                    menoresIdade.Add(p);
                }
            }

            //Como ordenar
            //List<Pessoa> pessoasOrdenadasPorAltura = 
            // pessoa.OrderBy(p => p.Altura).ThenBy(c=> c.Idade).ToList();

            //Lambda = Where/OrderBy/FirstOrDefault
            pessoas.Where(c => c.Altura > 2 && c.Nome.ToUpper().StartsWith("E"));

            List<Pessoa> pessoasOrdenadasPorAltura = pessoas.OrderByDescending(p => p.Altura).ThenBy(c => c.Idade).ToList();

            pessoas.Where(pes => pes.Idade < 18);



            //Delegate é um metodo antigo não mais usado
            // pessoas.Where(PessoasQueNaoPodemSerPresas); criada uma funcao pra chamar

            // No metodo novo é feito muito mais fácil => pessoas.Where(pes => pes.Idade < 18);



            List<int> numeros = new List<int>();
            Random rdm = new Random();

            

            for (int i = 0; i < 10; i++)
            {
                //Gera um numero aleatorio de 0 a 100
                int valorGeradoAleatoriamente = rdm.Next(100);

               if(!numeros.Contains(valorGeradoAleatoriamente))
                {
                    //Adiciona o numero gerado pelo random (que nao é repetido)
                    numeros.Add(valorGeradoAleatoriamente);
                }
                else
                {
                    i--;
                }
                
            }
            
            Console.ReadLine();


            //Amigos a = new Amigos();
            //a.Nome = "Felipe";
            //a.TempoAmizade = 20;
            //Casar(a);
            //Console.WriteLine(a.Nome);


            //int i = 30;
            //Hebeficar(ref i);
            //Console.WriteLine(i);



        }
        //static void Casar(Amigos b)
        //{
        //    b.Nome += " Bernart";
        //}
        //static void Hebeficar(ref int idade)
        //{
            
        //    idade = 16000;
        //}

        public static void Listar()
        {
           

            var objpessoa = new Pessoa();
            cadastroPessoa.Add(objpessoa);
            Console.WriteLine("---------------------------------------------");
            cadastroPessoa.ForEach(i => Console.WriteLine($"Nome: {i.Nome}\r\n" +
                $"Idade: {i.Idade}\r\n" +
                $"Sexo: {i.Sexo}\r\n" +
                $"Altura: {i.Altura}\r\n"));
        }
        public static void AdicionarPessoa()
        {
            var cadastroPessoa = new List<Pessoa>();

            var objpessoa = new Pessoa();

            Console.WriteLine("Digite o nome:");
            objpessoa.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade:");
            objpessoa.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o sexo:");
            objpessoa.Sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura:");
            objpessoa.Altura = double.Parse(Console.ReadLine());

       
            Console.WriteLine("Deseja Cadastrar mais alguém? (1) Sim (2) Não");
            var opcao = int.Parse(Console.ReadLine());
           

            switch (opcao)
            {
                case 1:
                    {
                        AdicionarPessoa();
                    }break;
                case 2:
                    {
                        Listar();
                    }break;
                default:
                    break;
            }
            Console.ReadKey();
            


        }
        

    }
    
}






