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
        private List <Pokemon> pokemons;

        public List<Pokemon> _Pokemons
        {
            get { return  pokemons; }
            
        }

        private void InicializaLista()
        {
            //Instanciar a lista
            this.pokemons = new List<Pokemon>();
            Pokemon p = new Pokemon("Bubassauro","Ele é do Tipo Planta");
            this.pokemons.Add(p);
            p = new Pokemon("Charmander", "Tipo dragão fogo");
            this.pokemons.Add(p);
            p = new Pokemon("Pikachu", "Tipo gato eletrico");
            this.pokemons.Add(p);
            p = new Pokemon("Squarte", "Tipo tartaruga marinha");
            this.pokemons.Add(p);
            p = new Pokemon("blastoize", "Tipo tartaruga evoluída");
            this.pokemons.Add(p);
            p = new Pokemon("Charizard", "Tipo dragão fogo pokevoluido");
            this.pokemons.Add(p);
            p = new Pokemon("Miau", "Tipo gato da equipe roquet");
            this.pokemons.Add(p);
            p = new Pokemon("Mewtwuo", "Tipo raro");
            this.pokemons.Add(p);
            p = new Pokemon("Mio", "Tipo rarissimo");
            this.pokemons.Add(p);
            p = new Pokemon("Metagross", "Tipo louco");
            this.pokemons.Add(p);

        }
        public void ListarPokemons()
        {
            for (int i = 0; i < this._Pokemons.Count; i++)
            {
                this._Pokemons[i].ExibirDadosPokemon();
                
            }
        }
    }
}
