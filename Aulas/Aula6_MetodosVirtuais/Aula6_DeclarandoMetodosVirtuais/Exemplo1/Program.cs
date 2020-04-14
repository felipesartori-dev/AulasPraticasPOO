using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("Felipe", 23);
            Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
