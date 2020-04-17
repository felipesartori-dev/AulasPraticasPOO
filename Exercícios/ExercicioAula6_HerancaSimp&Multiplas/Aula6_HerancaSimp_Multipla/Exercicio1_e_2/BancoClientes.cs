using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_e_2
{
    class BancoClientes
    {

        List<ContaEspecial> bancoDadosCliente = new List<ContaEspecial>();

        public void insereNovoCliente(ContaEspecial cliente)
        {
            bancoDadosCliente.Add(cliente);
        }

        public ContaEspecial getCliente(int posicao)
        {
            return bancoDadosCliente.ElementAt(posicao);
        }

        public int getQuantiaClientes()
        {
            return bancoDadosCliente.Count();
        }
    }
}
