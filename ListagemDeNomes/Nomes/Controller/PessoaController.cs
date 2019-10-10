using Nomes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nome.Controller
{
    public class PessoaController
    {
        PessoasContextDB contextDB = new PessoasContextDB();


        
        public IQueryable<Pessoas> GetNomes()
        {
            return contextDB.Nomes.Where(i => i.Ativo == true);
        }

        public bool InserirNome(Pessoas item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome))
                return false;

            contextDB.Nomes.Add(item);
            contextDB.SaveChanges();

            return true;
        }
       

    }
}
