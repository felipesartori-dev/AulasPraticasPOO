using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    class Tela
    {
        public void desenharLinha()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        public void pintarTela(ConsoleColor corDeFundo, ConsoleColor corDeFonte)
        {
            Console.ForegroundColor = corDeFonte;
            Console.BackgroundColor = corDeFundo;
            Console.Clear();
        }
        public int dobra(int nr)
        {
            int dobro;
            dobro = nr * 2;

            return dobro;
        }
    }
}
