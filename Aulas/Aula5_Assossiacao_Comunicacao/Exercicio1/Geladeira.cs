using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Geladeira
    {
        //private Fruta[] frutas;
        //private int qtdFrutas;
        private List<Fruta> frutas;

        public Geladeira()
        {
            //frutas = new Fruta[20];
            //qtdFrutas = 0;
            frutas = new List<Fruta>();
        }

        public void adicionaFrutas(Fruta fruta)
        {
            frutas.Add(fruta);
            //frutas[qtdFrutas] = fruta;
            //qtdFrutas++;
        }

        public Fruta getFruta(int posicao)
        {
            //return frutas[posicao];
            return frutas.ElementAt(posicao);
        }
    }
}
