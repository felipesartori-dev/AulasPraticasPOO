using System;

namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro[] carros = new Carro[5];

            for (int x = 0; x < 5; x++)
            {
                carros[x] = new Carro();
                Console.WriteLine("Entre com o Modelo: ");
                carros[x].modelo = Console.ReadLine();
                Console.WriteLine("Entre com a Marca: ");
                carros[x].marca = Console.ReadLine();
                Console.WriteLine("Entre com o Ano de Fabricação: ");
                carros[x].anoFabricacao = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre com a Cor: ");
                carros[x].cor = Console.ReadLine();
                Console.Clear();
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("**************************************************************");

                Console.WriteLine("Marca: {0}\t Modelo: {1}\t anoFabricacao: {2}\t Cor: {3}", carros[i].marca, carros[i].modelo, carros[i].anoFabricacao, carros[i].cor);
            }

            Console.ReadKey();
        }
    }
}
