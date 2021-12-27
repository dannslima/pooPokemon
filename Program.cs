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
            Pokedex pokedex = new Pokedex();
            int resp = 100;
            while (resp !=0 )
            {
                resp = Menu();
                if (resp == 1)
                {
                    pokedex.ListarPokemons();
                }
                Console.ReadKey();
                Console.Clear();
            }
            

            Console.ReadKey();
        }

        static int Menu()
        {
            Console.WriteLine("Pokedex");
            Console.WriteLine("0 - Sair da Pokedex");
            Console.WriteLine("1 - Listar todos os Pokemons");
            Console.WriteLine("Digite a opção desejada");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
        
    }
}
