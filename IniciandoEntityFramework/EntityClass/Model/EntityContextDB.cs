using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class EntityContextDB : 
        DbContext //DbContext classe pronta que contem todo os processos de conexão com o banco
        //listagem das tabelas seleção das informacoes

    {
        public DbSet
            //Palavra reserva para o Entity que indica que vamos definir uma tabela do nosso
            //banco de dados 
            <Pessoa> listaDePessoas { get; set; }
    }
}
