using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercicio2._8
{
    public class Calculadora
    {
        private Double total;
        public Double Total
        {
            get { return total; }
        }

        public Calculadora()
        {
            total = 0;
        }
        public void somar(Double valor)
        {
            total += valor;
        }

        public void subtrair(Double valor)
        {
            total -= valor;
        }
    }
}
