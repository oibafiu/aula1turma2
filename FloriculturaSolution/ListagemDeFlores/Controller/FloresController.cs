using ListagemDeFlores.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeFlores.Controller
{
    public class FloresController
    {
        FloresContextDB contextDB = new FloresContextDB();

        public IQueryable<Flores> GetFlores()
        {
            return contextDB.Flores.Where(i => i.Ativo == true);

        }

        public bool InserirFlores(Flores item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome)) ;

            if (item.Quantidade <= 0) return false;

            contextDB.Flores.Add(item);
            contextDB.SaveChanges();
            return true;
        }
    }
}
