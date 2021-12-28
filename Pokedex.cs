using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemon
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializaLista();
        }
        private List <PokemonPlus> pokemons;

        public List<PokemonPlus> _Pokemons
        {
            get { return  pokemons; }
            
        }

        private void InicializaLista()
        {
            //Instanciar a lista
            this.pokemons = new List<PokemonPlus>();
            PokemonPlus p = new PokemonPlus("Bubassauro","Ele é do Tipo Planta",45);
            this.pokemons.Add(p);
            p = new PokemonPlus("Charmander", "Tipo dragão fogo",30);
            this.pokemons.Add(p);
            p = new PokemonPlus("Pikachu", "Tipo gato eletrico",39);
            this.pokemons.Add(p);
            p = new PokemonPlus("Squarte", "Tipo tartaruga marinha",21);
            this.pokemons.Add(p);
            p = new PokemonPlus("blastoize", "Tipo tartaruga evoluída",50);
            this.pokemons.Add(p);
            p = new PokemonPlus("Charizard", "Tipo dragão fogo pokevoluido",50);
            this.pokemons.Add(p);
            p = new PokemonPlus("Miau", "Tipo gato da equipe roquet",10);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mewtwuo", "Tipo raro",100);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mio", "Tipo rarissimo",110);
            this.pokemons.Add(p);
            p = new PokemonPlus("Metagross", "Tipo louco",80);
            this.pokemons.Add(p);

        }
        public void ListarPokemons()
        {
            for (int i = 0; i < this._Pokemons.Count; i++)
            {
                Console.WriteLine("CODIGO POKEMON: " + i);
                this._Pokemons[i].ExibirDadosPokemonPlus();
                
            }
        }
    }
}
