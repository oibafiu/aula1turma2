using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaCarros.Model
{
    
    class Carro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public string Data { get; set; }
    }
    public List<Carro> listaDeCarros { get; set; }
}
