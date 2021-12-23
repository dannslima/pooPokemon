using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemon
{
    public class Pokemon
    {
        public Pokemon()
        {
            this._Nome = "";
            this._Descricao = "";
        }
        private string nome;

        public string _Nome
        {
            get { return nome; }
            set {
                String texto = value.ToUpper();
                nome = texto;
            }
        }

        private String descricao; //ARMAZENA O VALOR DA PROPRIEDADE DESCRICAO

        public String _Descricao // PROPRIEDADE REPRESENTA A CARACTERISTICA DESCRICAO DO MEU POKEMON
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }

        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Nome do Pokemon: " + this._Nome);
            Console.WriteLine("Descrição do Pokemon" + this._Descricao);
        }

    }
}
