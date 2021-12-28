using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemon
{
    public class PokemonPlus:Pokemon
    {
        public PokemonPlus():base()
        {
            this._Poder = 0;
        }

        public PokemonPlus(String nome, String descricao , int poder) : base(nome, descricao)
        {
            this._Poder = poder;
        }

        public int _Poder { get; set; }

        public void ExibirDadosPokemonPlus()
        {
            Console.WriteLine("Nome do Pokemon: " + this._Nome);
            Console.WriteLine("Descrição do Pokemon" + this._Descricao);
            Console.WriteLine("Poder: " + this._Poder);
            Console.WriteLine("--------------------------------");

        }
    }
}
