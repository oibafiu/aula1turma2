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
        private int IdContador = 1;
        public LivrosController() //o metodo construtor deve ser sempre do mesmo nome da Classe
        {
        ListaDeLivros = new List<Livro>();
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = "Meu Primeiro Livro"

            }); 
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = "Meu segundo livro"
                
            });

        }
        private List<Livro> ListaDeLivros { get; set; }
        public void AdicionarLivro(Livro parametroLivro)
        {
            //Adicionamos o livro em nossa lista
            parametroLivro.Id = IdContador++;
            ListaDeLivros.Add(parametroLivro);
        }
        public List<Livro> RetornaListaDeLivros()
        {
            return ListaDeLivros;
        }
    }
}
