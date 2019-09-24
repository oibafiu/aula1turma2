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
        private LocacaoContext contextDB = new LocacaoContext();
        
        private List<Livro> ListaDeLivros { get; set; }
        public void AdicionarLivro(Livro parametroLivro)
        {
            //Adicionamos o livro em nossa lista
            parametroLivro.Id = contextDB.IdContadorLivros++;
            ListaDeLivros.Add(parametroLivro);
        }
        public List<Livro> RetornaListaDeLivros()
        {
            return contextDB.ListaDeLivros.Where(i => i.Ativo).ToList<Livro>();
        }
        public void RemoverLivrosPorID(int identificadorID)
        {
            //Aqui usamos o metodo firstordefault para localizar nosso usuario dentro da lista, com isso conseguimos acessar as
            //propriedades dele e desativar o registro
            var livro = ListaDeLivros.FirstOrDefault(i => i.Id == identificadorID);

            if (livro != null)
                livro.Ativo = false;
        }
    }
}

