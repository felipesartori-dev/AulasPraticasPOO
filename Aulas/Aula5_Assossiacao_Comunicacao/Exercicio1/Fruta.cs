using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Fruta
    {
        public Fruta()
        {
            nome = "Frutas sem nome";
            dataValidade = DateTime.Now;
        }

        private String nome;
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public String getNome()
        {
            return nome;
        }

        private DateTime dataValidade;
        public void setDataValidade(DateTime dataValidade)
        {
            this.dataValidade = dataValidade;
        }
        public DateTime getDataValidade()
        {
            return dataValidade;
        }

        public bool getVerificaValidade()
        {
            {
                return dataValidade >= DateTime.Now;
            }
        }
    }
}
