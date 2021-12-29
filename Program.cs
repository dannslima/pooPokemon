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
                else if (resp ==2)
                {
                    pokedex.ListarPokemons();
                    Console.WriteLine("Selecione o codigo do Pokemon");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    //PEGAR O POKEMON DO JOGADOR
                    PokemonPlus pPlayer = pokedex._Pokemons[codigo];
                    //DEFINIR O POKEMON ADVERSÁRIO DA MAQUINA
                    Random r = new Random();
                    codigo = r.Next(0, pokedex._Pokemons.Count);
                    PokemonPlus pPc = pokedex._Pokemons[codigo];
                    Console.Clear();

                    //batalhar
                    Console.WriteLine("Dados do pokemons que irão lutar**************************");
                    Console.WriteLine("Dados do seu Pokemon");
                    pPlayer.ExibirDadosPokemonPlus();
                    Console.WriteLine("Dados do Pokemon da máquina");
                    pPc.ExibirDadosPokemonPlus();

                    if (pPlayer._Poder >= pPc._Poder)
                    {
                        Console.WriteLine(pPlayer._Nome + " X " + pPc._Nome);
                        Console.WriteLine("Você venceu a batalha");
                    }
                    else
                    {
                        Console.WriteLine(pPlayer._Nome + " X " + pPc._Nome);
                        Console.WriteLine("Você perdeu a batalha");
                    }
                    
                }
                Console.ReadKey();
                Console.Clear();
            }
            

            Console.ReadKey();
        }

        static int Menu()
        {
            
            Console.WriteLine("POKÉMON---JOGO DE BATALHA");
            Console.WriteLine("0 - Sair do Jogo");
            Console.WriteLine("1 - Listar todos os Pokemons da Pokedex");
            Console.WriteLine("2 - Batalhar");
            Console.WriteLine("Digite a opção desejada");
            int resp = Convert.ToInt32(Console.ReadLine());
            while (resp != 0 && resp != 1 &&  resp != 2 )
            {
                Console.WriteLine("OPÇÃO INVALIDA");
                Console.WriteLine("POKÉMON---JOGO DE BATALHA");
                Console.WriteLine("0 - Sair do Jogo");
                Console.WriteLine("1 - Listar todos os Pokemons da Pokedex");
                Console.WriteLine("2 - Batalhar");
                Console.WriteLine("Digite a opção desejada");
                resp = Convert.ToInt32(Console.ReadLine());
            }
            return resp;
        }
        
    }
}
