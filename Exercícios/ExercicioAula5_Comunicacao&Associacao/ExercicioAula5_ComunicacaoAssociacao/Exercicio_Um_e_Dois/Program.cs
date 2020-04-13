using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Um_e_Dois
{
    class Program
    {
        static void Main(string[] args)
        {
            BancoClientes insereCliente = new BancoClientes();
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("0 - Sair do sistema");
                Console.WriteLine("1 - Adicionar cliente");
                Console.WriteLine("2 - Listar clientes");
                Console.WriteLine("3 - Consultar clientes");
                Console.WriteLine("4 - Editar clientes");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        {
                            Console.Clear();
                            Console.WriteLine("O sistema será encerrado.");
                        }
                        break;
                    case 1:
                        {
                            Console.Clear();
                            Cliente cliente = new Cliente();
                            Endereco endereco = new Endereco();
                            pegaDadosCliente(cliente, endereco);
                            insereCliente.gravaCliente(cliente);
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Clientes cadastrados: \n");
                            for (int i = 0; i < insereCliente.getQuantiaClientes(); i++)
                            {
                                Console.WriteLine($"Código cliente {i}: {insereCliente.getCliente(i).Nome}\t CPF: {insereCliente.getCliente(i).Cpf}\n");
                            }
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.Write("Digite o CPF do cliente que quer consultar (XXX.XXX.XXX-XX).");
                            String buscaCPF = Console.ReadLine();
                            bool encontrou = false;

                            for (int i = 0; i < insereCliente.getQuantiaClientes(); i++)
                            {
                                if (buscaCPF == insereCliente.getCliente(i).Cpf)
                                {
                                    encontrou = true;
                                    Console.WriteLine($"Nome: {insereCliente.getCliente(i).Nome}\t CPF: {insereCliente.getCliente(i).Cpf}\t Data de Nascimento: {insereCliente.getCliente(i).DataNascimento}\t Idade: {insereCliente.getCliente(i).Idade}\t Rua: {insereCliente.getCliente(i).Endereco.NomeRua}\t Nº: {insereCliente.getCliente(i).Endereco.Numero}\t Complemento: {insereCliente.getCliente(i).Endereco.Complemento}\t CEP: {insereCliente.getCliente(i).Endereco.Cep}\t Cidade: {insereCliente.getCliente(i).Endereco.Cidade}\t UF: {insereCliente.getCliente(i).Endereco.Uf}\n");
                                }
                            }
                            if (!encontrou)
                            {
                                Console.WriteLine("CPF não encontrado, tente novamente.");
                            }
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Digite o CPF do cliente que quer editar - Utilize o formato (XXX.XXX.XXX-XX): ");
                            String buscaCPF = Console.ReadLine();

                            editaCliente(insereCliente, buscaCPF);
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Foi passado um valor incorreto, tente novamente.");
                        Console.ReadKey();
                        break;
                }
            } while (op != 0);
        }

        private static void pegaDadosCliente(Cliente cliente, Endereco endereco)
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
        private static void editaCliente(BancoClientes insereCliente, String buscaCPF)
        {
            for (int i = 0; i < insereCliente.getQuantiaClientes(); i++)
            {
                if (buscaCPF == insereCliente.getCliente(i).Cpf)
                {
                    Console.Write("Nome do cliente: ");
                    insereCliente.getCliente(i).Nome = Console.ReadLine();
                    Console.Write("CPF do cliente (XXX.XXX.XXX-XX): ");
                    insereCliente.getCliente(i).Cpf = Console.ReadLine();
                    Console.Write("Data de nascimento do cliente: ");
                    insereCliente.getCliente(i).DataNascimento = Console.ReadLine();
                    Console.Write("Idade do cliente: ");
                    insereCliente.getCliente(i).Idade = int.Parse(Console.ReadLine());
                    Console.Write("Nome da rua: ");
                    insereCliente.getCliente(i).Endereco.NomeRua = Console.ReadLine();
                    Console.Write("Número: ");
                    insereCliente.getCliente(i).Endereco.Numero = Console.ReadLine();
                    Console.Write("Complemento: ");
                    insereCliente.getCliente(i).Endereco.Complemento = Console.ReadLine();
                    Console.Write("CEP: ");
                    insereCliente.getCliente(i).Endereco.Cep = Console.ReadLine();
                    Console.Write("Cidade: ");
                    insereCliente.getCliente(i).Endereco.Cidade = Console.ReadLine();
                    Console.Write("UF: ");
                    insereCliente.getCliente(i).Endereco.Uf = Console.ReadLine();
                }
            }
        }
    }
}
