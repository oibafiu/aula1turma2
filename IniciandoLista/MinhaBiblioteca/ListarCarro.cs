using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
     public class ListarCarro
    {
        public static void ListaCarro()
        {
            var minhaLista = new List<string>
            {


                "Audi",
                "Volksvagem",
                "Fiat",
                "BMW",
                "Ferrari"
            };

            minhaLista.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }
    }
}
