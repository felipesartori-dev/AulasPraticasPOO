using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho
{
    class ContaCorrente: Cliente
    {
        public Double saldo;

        public ContaCorrente()
        {
            saldo = 0;
        }

        public void Depositar(Double valor)
        {
            saldo += valor;
        }

        public void Sacar(Double valor)
        {
            saldo -= valor;
        }

        public Double VerSaldo()
        {
            return saldo;
        }
    }
}
