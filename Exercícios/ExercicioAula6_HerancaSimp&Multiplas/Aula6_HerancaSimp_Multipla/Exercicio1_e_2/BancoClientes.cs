using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_e_2
{
    class BancoClientes
    {

        List<ContaCorrente> bancoDadosCliente = new List<ContaCorrente>();

        public void insereNovoCliente(ContaCorrente cliente)
        {
            bancoDadosCliente.Add(cliente);
        }

        public ContaCorrente getCliente(int posicao)
        {
            return bancoDadosCliente.ElementAt(posicao);
        }

        public int getQuantiaClientes()
        {
            return bancoDadosCliente.Count();
        }
    }
}
