using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_e_2
{
    class Cliente
    {
        private String nome;
        private String dataNascimento;
        private String cpf;
        private String tipoConta;

        public string Nome { get => nome; set => nome = value; }
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string TipoConta { get => tipoConta; set => tipoConta = value; }
    }
}
