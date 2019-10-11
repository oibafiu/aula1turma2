using Flores.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flores.Controller
{
    public class FloresController
    {
        FloresContextDB contextDB = new FloresContextDB();

        public IQueryable<Flores> GetFlores();
    }
}
