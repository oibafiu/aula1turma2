using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RevisandoEntity.Model;



namespace AplicacaoVisual
{
    
    class Program
    {
        static void Main(string[] args)
        {
            CervejaContext cerveja = new CervejaContext();
            cerveja.Cervejas.Add(new Cerveja() { Nome = "Daniel Cerveja"});
            cerveja.SaveChanges();

        }
    }
}
