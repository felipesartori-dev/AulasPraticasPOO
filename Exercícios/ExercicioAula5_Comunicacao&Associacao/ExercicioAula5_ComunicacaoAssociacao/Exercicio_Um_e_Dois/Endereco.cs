using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Um_e_Dois
{
    class Endereco
    {
        private String nomeRua;
        private String numero;
        private String complemento;
        private String cep;
        private String cidade;
        private String uf;

        public string NomeRua { get => nomeRua; set => nomeRua = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
    }
}
