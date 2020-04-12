using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Um_e_Dois
{
    class Cliente
    {
        public String nome { get; set; }
        public String CPF { get; set; }
        public String dataNascimento { get; set; }
        public int idade { get; set; }
        public Endereco endereco { get; set; }

        /* Exemplo de como fazer get e set de forma mais simples
         * 
         * private String _teste;
        public String Teste
        {
            get { return _teste; }
            set { _teste = value; }
        }*/


    }
}
