using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Model;

namespace SistemaRelatorioCarros.Controller
{
    public class VendasController
    {
        SistemaVendasContext vendasContext = new SistemaVendasContext();

        public List<Venda> GetVendas(int mes = 0)
        {
            //retornamos nossa lista de vendas sem nenhum filtro nesse momento
            if (mes == 0)
                return vendasContext.ListaVendasPublica;
            else
                return vendasContext.ListaVendasPublica.FindAll(i => i.Data.Month == mes);
        }
    }
}
