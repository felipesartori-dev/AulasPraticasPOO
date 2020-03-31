using System;
using System.Collections.Generic;
using System.Text;

namespace Exer1
{
    class ListaIdade
    {
        private int[] idades = new int[20];

        public int quantidade = 0;

        public void AdicionarIdade(int valor)
        {
                idades[quantidade] = valor;
                quantidade++;
        }
        public void AtualizarIdade(int indice, int idade)
        {
            idades[indice - 1] = idade;
        }
        public void GetListIdades()
        {
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Índice: {0} - Idade: {1}",i + 1, idades[i]);
            }
        }
        public void GetListOrdenadaIdades()
        {
            for (int x = 0; x < quantidade; x++)
            {
                for (int y = x + 1; y < quantidade; y++)
                {
                    if (idades[x] > idades[y])
                    {
                        int aux = idades[x];
                        idades[x] = idades[y];
                        idades[y] = aux;
                    }
                }
            }
            GetListIdades();
        }
    }
}
