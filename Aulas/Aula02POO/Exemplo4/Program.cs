using System;

namespace Exemplo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("Qual operação você deseja realizar ?");
            Console.WriteLine("1 - Soma | 2 - Subtração | 3 - Multiplicação");
            int op = int.Parse(Console.ReadLine());
            int n1, n2;
            Console.Write("Digite o primeiro número:");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número:");
            n2 = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    int resultadoSoma = calc.calculaSoma(n1, n2);
                    Console.WriteLine("O resultado da soma é: {0}", resultadoSoma);
                    break;
                case 2:
                    int resultadoSub = calc.calculaSub(n1, n2);
                    Console.WriteLine("O resultado da subtração é: {0}", resultadoSub);
                    break;
                case 3:
                    int resultadoMult = calc.calculaMult(n1, n2);
                    Console.WriteLine("O resultado da multiplicação é: {0}", resultadoMult);
                    break;
                default:
                    Console.WriteLine("Tecla errada digitada");
                    break;
            }

            Console.ReadKey();
        }
    }
}
