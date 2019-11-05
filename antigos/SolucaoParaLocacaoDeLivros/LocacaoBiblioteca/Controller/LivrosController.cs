using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Model;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController
    {
        LocacaoContext contextDB = new LocacaoContext();
        public IQueryable<Livro> GetLivros()
        {
            return contextDB.Livros.Where(i => i.Ativo == true);
        }

        public bool AtualizarLivro(Livro item)
        {
            var livro = contextDB.Livros.FirstOrDefault(i => i.Id == item.Id);

            if (livro == null)
                return false;
            else
            {

                livro.DataAlteracao = DateTime.Now;
            }

            contextDB.SaveChanges();

            return true;
        }

        public bool InserirLivro(Livro item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome))
                return false;

            contextDB.Livros.Add(item);
            contextDB.SaveChanges();

            return true;
        }
        
        public bool RemoverLivro(int id)
        {
            var livro = contextDB.Livros.FirstOrDefault(i => i.Id == id);

            if (livro == null)
                return false;

            livro.Ativo = false;

            contextDB.SaveChanges();

            return true;
        }
    }
}




