using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_e_2
{
    class ContaEspecial : ContaCorrente
    {
        private Double limite;

        public ContaEspecial()
        {
            limite = 1000.00;
        }

        public Double AumentarLimite(double aumentoLimite)
        {
            return this.limite += aumentoLimite;
        }

        public Double DiminuirLimite(double diminuiLimite)
        {
            return this.limite -= diminuiLimite;
        }

        public Double ConsultarLimite()
        {
            return limite;
        }

        public override void Sacar(double valor)
        {
            Double credito = saldo + limite;

            if (valor > credito)
            {
                Console.WriteLine("Não foi possivel sacar, você não tem tanto saldo\n");
            }
            else
            {
                saldo -= valor;
            }
        }
    }
}
