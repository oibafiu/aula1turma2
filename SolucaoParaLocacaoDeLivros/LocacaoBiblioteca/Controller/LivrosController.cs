using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController
    {
        public LivrosController() //o metodo construtor deve ser sempre do mesmo nome da Classe
        {
        livros = new List<Livro>();
            livros.Add(new Livro()
            {
                Nome = "Meu Primeiro Livro"
            });
            livros.Add(new Livro()
            {
                Nome = "Meu segundo livro"
            });

        }
        public List<Livro> livros { get; set; }
    }
}
