using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1.Model
{
    public class Objeto
    {
        //classe poko

        [Key]
        const double Gravidade = 9.807;
        public double Densidade { get; set; } = 0;
        public double Volume { get; set; } = 0;

        public double Peso 
        {
            get { return ((Densidade * Volume) * Gravidade); }
        }

    }
}
