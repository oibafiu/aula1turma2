﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBicicletas.Model
{
    public class Bicicleta
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public double Valor { get; set; }
        public bool Ativo { get; set } = true;
    }
}
