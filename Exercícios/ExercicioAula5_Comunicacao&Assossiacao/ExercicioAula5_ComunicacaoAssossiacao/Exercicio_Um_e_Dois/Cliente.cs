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

        /*public void setNome(String nomeRua)
        {
            this.nome = nomeRua;
        }
        public String getNome()
        {
            return nome;
        }*/

        public String CPF { get; set; }
        public String dataNascimento { get; set; }
        public int idade { get; set; }
        public Endereco endereco { get; set; }
    }
}
