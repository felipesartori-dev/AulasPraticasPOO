using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tela t1 = new Tela();
            t1.pintarTela(ConsoleColor.White, ConsoleColor.DarkMagenta);
            t1.desenharLinha();

            int resultado = t1.dobra(5);
            Console.WriteLine(resultado);
        }
    }
}
