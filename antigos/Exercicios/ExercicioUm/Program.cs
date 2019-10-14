using ExercicioUm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                var amigos = new List<ListaAmigos>();
                amigos.Add(new ListaAmigos()
                {
                    Nome = "Bárbara",
                    TempoAmizade = 9
                });
                amigos.Add(new ListaAmigos()
                {
                    Nome = "Elton",
                    TempoAmizade = 10
                });
                amigos.Add(new ListaAmigos()
                {
                    Nome = "Ketlin",
                    TempoAmizade = 3
                });

                amigos.ForEach(i => Console.WriteLine($"Amigo:{i.Nome} \r\n" +
                    $"Tempo de Amizade:{i.TempoAmizade}"));
                Console.ReadKey();
            }


        }

    }
}

                
       
    

