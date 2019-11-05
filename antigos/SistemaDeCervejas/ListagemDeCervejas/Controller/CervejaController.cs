using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Model;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        SistemaCervejaContext cervejaContext = new SistemaCervejaContext();

        private List<Cerveja> ListaDeCerveja { get; set; }




        /// <summary>
        /// Metodo que retorna nossa lista de cervejas completa
        /// </summary>
        /// <param name="cerveja"></param>
        /// <returns>Retorna nossa lista de cervejas completa</returns>
        public List<Cerveja> GetCerveja()
        {
            //retornamos nossa lista de cerveja sem nenhum filtro nesse momento
            
            return cervejaContext.ListaDeCerveja; 

        }
        public void AdicionarCerveja(Cerveja cerveja)
        {
            
            
            cervejaContext.ListaDeCerveja.Add(cerveja);


        }
        /// <summary>
        /// Metodo que retorna os valores totais das cervejas
        /// </summary>
        public void ListarInformacoes()
        {
            var total = GetCerveja().Sum(i => i.Valor);
            var totalLitros = GetCerveja().Sum(i => i.Litros);
            Console.WriteLine($"Valor total:  {total.ToString("C")}");
            Console.WriteLine($"Litros total:  {totalLitros}");

        }
        public void GetInformacoes()
        {

            var totalLitros = GetCerveja().Sum(i => i.Litros * i.Alcool );
            
            
            
            

        }

    }
}
