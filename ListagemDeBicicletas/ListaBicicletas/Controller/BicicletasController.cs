using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaBicicletas.Model;

namespace ListaBicicletas.Controller
{
    public class BicicletasController
    {
        BicicletaContextDB contextDB = new BicicletaContextDB();
        public IQueryable<Bicicleta> GetBicicletas()
        {
            return contextDB.Bicicletas.Where(i => i.Ativo == true);
        }

        public static void InserirBike()
        {

        }

    }
}
