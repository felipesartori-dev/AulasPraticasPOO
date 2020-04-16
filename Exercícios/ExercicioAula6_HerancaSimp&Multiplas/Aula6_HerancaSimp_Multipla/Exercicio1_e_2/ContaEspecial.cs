using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_e_2
{
    class ContaEspecial:ContaCorrente
    {
        private Double limite;

        public ContaEspecial()
        {
            limite = 1000.00;
        }

        public double Limite { get => limite; set => limite = value; }

        public Double AumentarLimite(double aumentoLimite)
        {
            return limite += aumentoLimite;
        }

        public Double DiminuirLimite(double diminuiLimite)
        {
            return limite -= diminuiLimite;
        }

        public Double ConsultarLimite()
        {
            return limite;
        }

        public override void Sacar(double valor)
        {

            if (valor > saldo)
            {
                limite -= valor;
            }

            Double credito = saldo + limite;

            if (valor > credito)
            {
                throw new Exception("Valor do saque maior que o saldo");
            }
            else
            {
                saldo -= valor;
            }
        }
    }
}
