﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;



namespace AcessandoDllDoAmiguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            var dllDoAmiguinho = new MinhaBiblioteca.ListaCervejas();

            Console.WriteLine(dllDoAmiguinho.ListaCervejas());

            Console.ReadKey();
        }
    }
}
