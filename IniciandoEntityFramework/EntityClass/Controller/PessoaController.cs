using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;

namespace EntityClass.Controller
{
    public class PessoaController
    {
        EntityContextDB contextDB = new EntityContextDB();

        public IQueryable //Aqui temos nossa primeira interface com a classe
            //Iqueryable essa classe contem varias funcionalidades prontas para usar igual
            //ao banco de dados 
            <Pessoa> //Definimos o tipo que ira retornar
            GetPessoas() //Damos um nome ao nosso metodo
        {
            return contextDB.listaDePessoas; //retornamos nossa lista de pessoas 
        }
        /// <summary>
        /// Metodo para adicionar pessoa no banco de dados
        /// </summary>
        /// <param name="item">Item Pessoa</param>
        public void AddPessoa(Pessoa item)
        {
            contextDB.listaDePessoas.Add(item);
            contextDB.SaveChanges(); //Salvamos no banco
        }
    }
}
