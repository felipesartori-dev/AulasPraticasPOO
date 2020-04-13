using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Um_e_Dois
{
    class DadosClientes
    {
        public void PegaDados(Cliente cliente, Endereco endereco)
        {
            Console.WriteLine("Para adicionar o cliente preencha com as informações: ");
            Console.Write("Nome do cliente: ");
            cliente.Nome = Console.ReadLine();
            Console.Write("CPF do cliente (XXX.XXX.XXX-XX): ");
            cliente.Cpf = Console.ReadLine();
            Console.Write("Data de nascimento do cliente: ");
            cliente.DataNascimento = Console.ReadLine();
            Console.Write("Idade do cliente: ");
            cliente.Idade = int.Parse(Console.ReadLine());
            Console.Write("Nome da rua: ");
            endereco.NomeRua = Console.ReadLine();
            Console.Write("Número: ");
            endereco.Numero = Console.ReadLine();
            Console.Write("Complemento: ");
            endereco.Complemento = Console.ReadLine();
            Console.Write("CEP: ");
            endereco.Cep = Console.ReadLine();
            Console.Write("Cidade: ");
            endereco.Cidade = Console.ReadLine();
            Console.Write("UF: ");
            endereco.Uf = Console.ReadLine();

            cliente.Endereco = endereco;
        }

        public void EditaClientes(BancoClientes guardaCliente, String buscaCPF)
        {
            for (int i = 0; i < guardaCliente.getQuantiaClientes(); i++)
            {
                if (buscaCPF == guardaCliente.getCliente(i).Cpf)
                {
                    Console.Write("Nome do cliente: ");
                    guardaCliente.getCliente(i).Nome = Console.ReadLine();
                    Console.Write("CPF do cliente (XXX.XXX.XXX-XX): ");
                    guardaCliente.getCliente(i).Cpf = Console.ReadLine();
                    Console.Write("Data de nascimento do cliente: ");
                    guardaCliente.getCliente(i).DataNascimento = Console.ReadLine();
                    Console.Write("Idade do cliente: ");
                    guardaCliente.getCliente(i).Idade = int.Parse(Console.ReadLine());
                    Console.Write("Nome da rua: ");
                    guardaCliente.getCliente(i).Endereco.NomeRua = Console.ReadLine();
                    Console.Write("Número: ");
                    guardaCliente.getCliente(i).Endereco.Numero = Console.ReadLine();
                    Console.Write("Complemento: ");
                    guardaCliente.getCliente(i).Endereco.Complemento = Console.ReadLine();
                    Console.Write("CEP: ");
                    guardaCliente.getCliente(i).Endereco.Cep = Console.ReadLine();
                    Console.Write("Cidade: ");
                    guardaCliente.getCliente(i).Endereco.Cidade = Console.ReadLine();
                    Console.Write("UF: ");
                    guardaCliente.getCliente(i).Endereco.Uf = Console.ReadLine();
                }
            }
        }
    }
}
