using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemon
{
    public class Pokemon
    {
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

        }

    }
}
