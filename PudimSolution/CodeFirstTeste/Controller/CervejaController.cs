using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTeste.Controller
{
    public class CervejaController
    {
        CervejaContextDB contextDb = new CervejaContextDB(@"data source=(localdb)\MSSQLLocalDB;initial catalog=RevisandoEntity.Model.CervejaContext;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
    }
}
