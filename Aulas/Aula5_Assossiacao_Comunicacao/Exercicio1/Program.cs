using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruta banana = new Fruta();

            banana.setNome("Banana nanica"); 
            banana.setDataValidade(DateTime.Parse("22/03/2030"));

            Geladeira geladeira = new Geladeira();

            if (banana.getVerificaValidade())
            {
                geladeira.adicionaFrutas(banana);
                Console.WriteLine("Pode comer a {0}", geladeira.getFruta(0).getNome());
            }
            else
            {
                Console.WriteLine($"A fruta {banana.getNome()} está vencida. Ela Venceu em: {banana.getDataValidade().ToShortDateString()}.");
            }
        }
    }
}
