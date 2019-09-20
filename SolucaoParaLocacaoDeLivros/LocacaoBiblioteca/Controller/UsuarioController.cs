using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que contém os métodos de usuários do sistema
    /// </summary>
    public class UsuarioController
    {
        /// <summary>
        /// Metodo que realiza o login do usuário dentro do sistema
        /// para realizar o login padrão use:
        /// Login: Admin
        /// Senha: Admin
        /// </summary>
        /// <param name="Usuario">Passamos um objeto de nome usuario  como um parametro</param>
        /// <returns>Retorna verdadeiro caso o login e senha esteja correto e falso caso não esteja correto.</returns>
        public  bool LoginSistema(Usuario usuarios) //retorna um booleano true ou false 
        {
            if (usuarios.Login == "Admin" && usuarios.Senha == "Admin")
                return true;
            else
            {
                return false;
            }

        }

    }
}
