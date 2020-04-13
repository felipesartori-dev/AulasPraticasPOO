using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Um_e_Dois
{
    class Cliente
    {
        private String nome;
        private String cpf;
        private String dataNascimento;
        private int idade;
        private Endereco endereco;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public int Idade { get => idade; set => idade = value; }
        internal Endereco Endereco { get => endereco; set => endereco = value; }
    }
}
