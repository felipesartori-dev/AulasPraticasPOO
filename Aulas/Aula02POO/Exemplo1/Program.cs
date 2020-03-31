using System;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro fusca = new Carro();
            fusca.marca = "VW";
            fusca.modelo = "Fusca";
            fusca.anoFabricacao = 1980;
            fusca.cor = "Azul";

            Carro bmw = new Carro();
            bmw.marca = "BMW";
            bmw.modelo = "X6";
            bmw.anoFabricacao = 2020;
            bmw.cor = "Preta";

            Console.WriteLine("*** Carros ***\n");
            Console.WriteLine("Marca: {0}\t Modelo: {1}\t anoFabricacao: {2}\t Cor: {3}", fusca.marca, fusca.modelo, fusca.anoFabricacao, fusca.cor);
            Console.WriteLine("Marca: {0}\t Modelo: {1}\t anoFabricacao: {2}\t Cor: {3}", bmw.marca, bmw.modelo, bmw.anoFabricacao, bmw.cor);
            Console.ReadKey();
        }
    }
}
