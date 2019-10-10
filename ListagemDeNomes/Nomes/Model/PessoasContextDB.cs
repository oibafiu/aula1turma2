using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomes.Model
{
    public class PessoasContextDB : DbContext
    {
       public DbSet<Pessoas> Nomes { get; set; }
    }
}
