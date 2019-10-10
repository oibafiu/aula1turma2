using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;


namespace InterfaceBiblioteca
{
    class Program
    {
        //Carregamos para memoria nosso controlador de livros
        static LivrosController livros = new LivrosController();
        //Carregamos para memoria nosso controlador de usuário
        static UsuarioController usuarios = new UsuarioController();
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Loacação de Livros 1.0");

            //while (!RealizaLoginSistema())
            //    Console.WriteLine("Login e senha inválidos!!!!");
            MostraMenuSistema();

           
            Console.ReadKey();
        }



        /// <summary>
        /// Mostra no console o menu disponivel do sistema
        /// </summary>
        /// 


        public static void MostraMenuSistema()
        {

            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)
            {
                Console.Clear();
            Console.WriteLine("Sistema de Locação de livro 1.0");

            Console.WriteLine("----- Menu Sistema -----");
            Console.WriteLine("1 - Listar Usuários");
            Console.WriteLine("2 - Listar Livros");
            Console.WriteLine("3 - Cadastrar Livros");
            Console.WriteLine("4 - Cadastrar Usuário");
            Console.WriteLine("5 - Remover Usuário");
                Console.WriteLine("6 - Remover Livros");
                Console.WriteLine("7 - Atualizar Usuario");
                Console.WriteLine("8 - Atualizar Livro");
                Console.WriteLine("0 - Sair");


                var opcao = int.MinValue;

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
            {
                case 1:
                    ListarUsuario();
                    break;
                case 2: MostrarLivro();
                        break;
                    case 3:
                        AdicionarLivro();
                        
                        break;
                    //case 4:
                    //    while (!RealizaLoginSistema())
                    //        Console.WriteLine("Login e senha inválidos!!!!");
                    //    break;
                    case 4:
                        AdicionarUsuario();
                        break;
                    case 5:
                        RemoverUsuario();
                        break;
                    case 6:
                        RemoverLivro();
                        break;
                    case 7:
                        AtualizarUsuario();
                        break;
                    case 8:
                        AtualizarLivro();
                        break;

                    default:
                    break;
            }
        }
    }
        private static void AdicionarUsuario()
        {
            Console.WriteLine("Cadastrar usuário dentro do sistema:");
            Console.WriteLine("Informe um login");
            var loginUsuario = Console.ReadLine();
            Console.WriteLine("Informe uma senha");
            var senhaUsuario = Console.ReadLine();

            var resultado = usuarios.InserirUsuario(new Usuario()
            {
                Login = loginUsuario,
                Senha = senhaUsuario
            });
            if (resultado)
                Console.WriteLine("Usuario cadastrado com sucesso!");
            else
                Console.WriteLine("Erro ao cadastrar");
        }
        private static void RemoverUsuario()
        {
            Console.WriteLine("Remover o usuário pelo ID no sistema!!");
            ListarUsuario();

            Console.WriteLine("Informe o ID para desativar no sistema");

                var usuarioId = int.Parse(Console.ReadLine());


                var resultado = usuarios.RemoverUsuario(usuarioId);
                if (resultado)
                    Console.WriteLine("Usuário removido com sucesso");
                else
                    Console.WriteLine("Erro ao remover usuário");


            }

            private static void RemoverLivro()
        {
            Console.WriteLine("Remover o livro pelo ID no sistema!!");
            MostrarLivro();

            Console.WriteLine("Informe o ID para desativar no sistema");

            var livroId = int.Parse(Console.ReadLine());


            var resultado = livros.RemoverLivro(livroId);
            if (resultado)
                Console.WriteLine("Livro removido com sucesso");
            else
                Console.WriteLine("Erro ao remover livro");
            Console.ReadKey();

        }
        public static void MostrarLivro()
        {
            livros.GetLivros().ToList<Livro>().ForEach
                 (i => Console.WriteLine($"Id:{i.Id}\r\n Nome: {i.Nome}"));
            Console.ReadKey();

        }
        public static void ListarUsuario()
        {
            usuarios.GetUsuarios().ToList<Usuario>().ForEach
                (i => Console.WriteLine($"Id:{i.Id}\r\n Login: {i.Login}"));
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que adiciona dentro da nossa lista um novo registro do livro
        /// </summary>
        private static void AdicionarLivro()
        {
            Console.WriteLine("---Inserir Livro---");
            Console.WriteLine("Informe o nome do livro");

            var nome = Console.ReadLine();

         
            var resultado = livros.InserirLivro(new Livro()
            {
                Nome = nome,
                
            });
            if (resultado)
                Console.WriteLine("Livro cadastrado com sucesso");
            else
                Console.WriteLine("Erro ao cadastrar livro");
        }
        public static void AtualizarUsuario()
        {
            Console.WriteLine("---Atualizar Usuário---");
            ListarUsuario();
            Console.WriteLine("Informe o Id para alteração de registro");
            var usuarioId = int.Parse(Console.ReadLine());

            var usuario = usuarios.GetUsuarios().FirstOrDefault(i => i.Id == usuarioId);

            if (usuario == null)
            {
                Console.WriteLine("Id informado inválido");
                return;
            }

            Console.WriteLine("Informe o novo login do usuário");

            usuario.Login = Console.ReadLine();

            Console.WriteLine("Informe a nova senha do Usuario");

            usuario.Senha = Console.ReadLine();

           
            var resultado = usuarios.AtualizarUsuario(usuario);

            if (resultado)
                Console.WriteLine("Usuario atualizado com sucesso");
            else
                Console.WriteLine("Erro ao atualizar usuario");
        }
        public static void AtualizarLivro()
        {
            Console.WriteLine("---Atualizar Livro---");
            MostrarLivro();
            Console.WriteLine("Informe o Id para alteração de registro");
            var livroId = int.Parse(Console.ReadLine());

            var livro = livros.GetLivros().FirstOrDefault(i => i.Id == livroId);

            if (livro == null)
            {
                Console.WriteLine("Id informado inválido");
                return;
            }

            Console.WriteLine("Informe o nome do livro atualizado");

            livro.Nome = Console.ReadLine();
            livro.DataAlteracao = DateTime.Now;

            var resultado = livros.AtualizarLivro(livro);

            if (resultado)
                Console.WriteLine("Livro atualizado com sucesso");
            else
                Console.WriteLine("Erro ao atualizar livro");
            Console.ReadKey();
        }


   




    //    //Informamos que o usuario esta na area de cadastro de livrs
    //    Console.WriteLine("Cadastrar livro dentro do sistema:");
    //    //INformamos que para dar continuidade ele deve informar um nome para o livrp
    //    Console.WriteLine("Nome do livro para cadastro:");
    //    //obtemos esta informação do usuario
    //    var nomeDoLivro = Console.ReadLine();

    //    //livrosController livros controle e nossos objetos em memoria
    //    //Com isso temos disponivel nele ferramentas que nos ajudam a realizar as tarefas
    //    //como adicionar um item a nossa lista de livros
    //    livrosController.AdicionarLivro(new Livro()
    //    {
    //        //Aqui "Atribuimos" o nome que demos ao livro na propriedade Nome de nosso livro
    //        //com o sinal de apenas um = temos atribuido passagem de valor

    //        Nome = nomeDoLivro

    //    }); 
    //    //Indico que finalizamos o processo de cadastro do livro, assim o usuário já sabe
    //    //que o mesmo foi realizado sem erros
    //    Console.WriteLine("Livro cadastrado com sucesso");
    //    Console.ReadKey();
    //}
    ///// <summary>
    ///// Metodo que realiza os procedimentos completos de login
    ///// dentro do sitema como solicitação de login e senha pelo console
    ///// assim como as respectivas validações que o mesmo prrecisa para entrar no sistema
    ///// </summary>
    ///// <returns>Retorna verdadeiro quando o login e senha informados estiverem corretos</returns>
    //public static bool RealizaLoginSistema()
    //{
    //    Console.Clear();
    //    //Informamos o que é preciso para entrar no sistema
    //    Console.WriteLine("Informe seu login e senha para acessar o sistema:");

    //    //Informamos no console que precisamos do Login do usuario
    //    Console.WriteLine("Login:");
    //    //Solicitamos o login
    //    var loginDoUsuario = Console.ReadLine();

    //    //Informamos no console que precisa da senha
    //    Console.WriteLine("Senha:");
    //    //Solicitamos a senha do usuario
    //    var senhaDoUsuario = Console.ReadLine();

    //    //aqui carregamos em memoria nosso controlador de usuarios 
    //    UsuarioController usuarioController = new UsuarioController();

    //    //Validamos o login de maneira duvidosa
    //    return usuarioController.LoginSistema(new Usuario()
    //    {
    //        Login = loginDoUsuario,
    //        Senha = senhaDoUsuario
    //    });
    //}
}

    }
    

