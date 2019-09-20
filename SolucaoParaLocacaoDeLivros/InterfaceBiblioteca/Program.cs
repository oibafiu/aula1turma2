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
        static LivrosController livros = new LivrosController();

        static UsuarioController usuarioController = new UsuarioController();
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Loacação de Livros 1.0");

            while (!RealizaLoginSistema())
                Console.WriteLine("Login e senha inválidos!!!!");
            MostraMenuSistema();

           
            Console.ReadKey();
        }
       
           
        
        /// <summary>
        /// Mostra no console o menu disponivel do sistema
        /// </summary>
        public static void MostraMenuSistema()
        {

            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)
            {
                Console.Clear();
            Console.WriteLine("Sistema de Locação de livro 1.0");

            Console.WriteLine("----- Menu Sistema -----");
            Console.WriteLine("1 - Listar Usuários");
            Console.WriteLine("2 - Livro");
            Console.WriteLine("3 - Usuario");
            Console.WriteLine("4 - Sair do sistema");
                Console.WriteLine("0 - Sair");
             
            menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());
            //Executar proxima funcao
            switch (menuEscolhido)
            {
                case 2:
                    MostrarLivro();
                    break;
                case 3: ListarUsuario();
                        break;
                    case 4:
                        while (!RealizaLoginSistema())
                            Console.WriteLine("Login e senha inválidos!!!!");
                        break;

                default:
                    break;
            }
        }
    }

        public static void MostrarLivro()
        {
            livros.livros.ForEach(i =>
            Console.WriteLine($"Nome do livro:{i.Nome}"));

            Console.ReadKey();
        }
        public static void ListarUsuario()
        {
            usuarioController.ListaDeUsuarios.ForEach(i =>
            Console.WriteLine($"Login do usuário:{i.Login}"));

            Console.ReadKey();
        }
        public static void SairDoSistema()
        {

            RealizaLoginSistema();
           
        }




        //Aqui vamos pegar numero digitado
        //Executar proxima funcao

        /// <summary>
        /// Metodo que realiza os procedimentos completos de login
        /// dentro do sitema como solicitação de login e senha pelo console
        /// assim como as respectivas validações que o mesmo prrecisa para entrar no sistema
        /// </summary>
        /// <returns>Retorna verdadeiro quando o login e senha informados estiverem corretos</returns>
        public static bool RealizaLoginSistema()
        {
            Console.WriteLine("Informe seu login e senha para acessar:");

            Console.WriteLine("Login:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senhaDoUsuario = Console.ReadLine();

            UsuarioController usuarioController = new UsuarioController();

            Usuario usuario = new Usuario();

            usuario.Login = loginDoUsuario;
            usuario.Senha = senhaDoUsuario;

            return usuarioController.LoginSistema(usuario);
            }    
        

        }

    }
    

