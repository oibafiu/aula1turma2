using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext
    {
        public int IdContadorLivros { get; set; } = 1;
        public int IdContadorUsuarios { get; set; } = 1;

        public LocacaoContext()
        {
            //criamos uma lista de livros em memória
                ListaDeLivros = new List<Livro>();
            //criamos uma lista de usuarios em memoria
            ListaDeUsuarios = new List<Usuario>();
           
            ListaDeLivros.Add(new Livro()
                {
                    Id = IdContadorLivros++,
                    Nome = "Meu Primeiro Livro"

                });
            ListaDeLivros.Add(new Livro()
                {
                    Id = IdContadorLivros++,
                    Nome = "Meu segundo livro"

                });
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                Nome = "Meu pequeno principe"

            });

            //Adicionamos o usuario
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "admin"

            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "123"

            });

        }
        
        public List<Livro> ListaDeLivros { get; set; }
        public List<Usuario> ListaDeUsuarios { get; set; }
        
    }
}
