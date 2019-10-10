using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que contem os metodos de usuários do sistema
    /// </summary>
    public class UsuarioController
    {
        LocacaoContext contextDB = new LocacaoContext();
        public IQueryable<Usuario> GetUsuarios()
        {
            return contextDB.Usuarios.Where(i => i.Ativo == true);
        }

        public bool AtualizarUsuario(Usuario item)
        {
            var usuario = contextDB.Livros.FirstOrDefault(i => i.Id == item.Id);

            if (usuario == null)
                return false;
            else
            {

                usuario.DataAlteracao = DateTime.Now;
            }

            contextDB.SaveChanges();

            return true;
        }

        public bool InserirUsuario(Usuario item)
        {
            if (string.IsNullOrWhiteSpace(item.Login))
                return false;

            contextDB.Usuarios.Add(item);
            contextDB.SaveChanges();

            return true;
        }

        public bool RemoverUsuario(int id)
        {
            var usuario = contextDB.Usuarios.FirstOrDefault(i => i.Id == id);

            if (usuario == null)
                return false;

            usuario.Ativo = false;

            contextDB.SaveChanges();

            return true;
        }
    }
}
