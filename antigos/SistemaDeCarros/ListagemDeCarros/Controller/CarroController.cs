using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;

namespace ListagemDeCarros.Controller
{
    public class CarroController
    {

        SistemaCarrosContext carrosContext = new SistemaCarrosContext();


        /// <summary>
        /// Metodo que retorna nossa lista de carros completa
        /// </summary>
        /// <param name="carros"></param>
        /// <returns>Retorna nossa lista de carros completa</returns>
        public List<Carro> GetCarro()
        {
            //retornamos nossa lista de vendas sem nenhum filtro nesse momento
           
                return carrosContext.ListaDeCarro;
            
        }
        
    }
}
