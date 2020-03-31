using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo4
{
    class Calculadora
    {
        public int calculaSoma(int n1, int n2)
        {
            int resultado = n1 + n2;

            return resultado;
        }
        public int calculaSub(int n1, int n2)
        {
            int resultado = n1 - n2;

            return resultado;
        }
        public int calculaMult(int n1, int n2)
        {
            int resultado = n1 * n2;

            return resultado;
        }
    }
}
