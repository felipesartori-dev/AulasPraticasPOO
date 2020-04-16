using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_e_2
{
    class ContaCorrente:Cliente
    {
        protected Double saldo;

        public double Saldo { get => saldo; set => saldo = value; }

        public ContaCorrente()
        {
            saldo = 0;
        }

        public void Depositar(Double valor)
        {
            saldo += valor;
        }

        public virtual void Sacar(Double valor)
        {
            if (valor > saldo)
            {
                throw new Exception("Valor do saque maior que o saldo");
            }
            else
            {
                saldo -= valor;
            }
        }

        public Double VerSaldo()
        {
            return saldo;
        }
    }
}
