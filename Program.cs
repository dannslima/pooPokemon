using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon p = new Pokemon("Bulbassauro" , "Bulbassauro é um pokemon tipo Planta..");
       
            p.ExibirDadosPokemon(false);
            Console.ReadKey();
        }
    }
}
