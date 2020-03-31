using System;

namespace Exemplo1_TesteDeHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.nome = "Felipe";
            pf.idade = 23;
            pf.cpf = "448.304.848-10";

            Console.WriteLine("Nome: {0}", pf.nome);
            Console.WriteLine("Idade: {0}", pf.idade);
            Console.WriteLine("CPF: {0}", pf.cpf);
            Console.ReadKey();

            PessoaJuridica pj = new PessoaJuridica();
            pj.cnpj = "4564871.454784/0001";
            pj.idade = 40;
            pj.nome = "Citel";

            Console.WriteLine("Nome: {0}", pj.nome);
            Console.WriteLine("Idade: {0}", pj.idade);
            Console.WriteLine("CNPJ: {0}", pj.cnpj);
            Console.ReadKey();
        }
    }
}
