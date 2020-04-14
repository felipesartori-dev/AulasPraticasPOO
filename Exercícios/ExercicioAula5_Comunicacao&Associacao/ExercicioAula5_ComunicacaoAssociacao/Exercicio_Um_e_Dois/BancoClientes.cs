using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Um_e_Dois
{
    class BancoClientes
    {
        private List<Cliente> guardaClientes = new List<Cliente>();

        public void gravaCliente(Cliente cliente){

            guardaClientes.Add(cliente);
        }

        public Cliente getCliente(int posicao)
        {
            return guardaClientes.ElementAt(posicao);
        }

        public List<Cliente> getAll()
        {
            return guardaClientes;
        }

        public int getQuantiaClientes()
        {
            return guardaClientes.Count();
        }
    }
}
