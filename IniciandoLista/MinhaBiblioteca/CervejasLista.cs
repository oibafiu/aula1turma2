using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class CervejasLista
    {
        public static void CervejaLista()
            {
            var cerveja = new List<string>();
            {
                cerveja.Add("Brahma");
                cerveja.Add("Skol");
                cerveja.Add("Patagonia");
                cerveja.Add("CARACU");


            }


            cerveja.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }

    }

}
