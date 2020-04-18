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

        public override void Sacar(double valor) {

            Double credito = saldo + limite;

            if (valor > credito) {
                Console.WriteLine($"Impossível sacar. Saldo insuficiente!");

                Console.ReadLine();
            } else {
                double aux = saldo - valor;
                if (aux < 0) {
                    if (valor < limite) {
                        limite += aux;
                        saldo = 0;
                        Console.WriteLine($"Valor do saque maior que o saldo. Limite utilizado! Limite Restante: R${limite}");
                        saldo -= valor;
                        Console.ReadLine();
                    } else {
                        Console.WriteLine($"Saldo insuficiente e valor maior que o limite.");
                        Console.ReadLine();
                    }
                } else {
                    saldo -= valor;
                }
            }     
        }
    }
}
