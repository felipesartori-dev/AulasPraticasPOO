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
            Cliente[] vetClientes = new Cliente[50];
            int posVetor = 0;
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

                            Console.WriteLine("Para adicionar o cliente preencha com as informações: ");
                            Console.Write("Nome do cliente: ");
                            cliente.nome = Console.ReadLine();
                            Console.Write("CPF do cliente (XXX.XXX.XXX-XX): ");
                            cliente.CPF = Console.ReadLine();
                            Console.Write("Data de nascimento do cliente: ");
                            cliente.dataNascimento = Console.ReadLine();
                            Console.Write("Idade do cliente: ");
                            cliente.idade = int.Parse(Console.ReadLine());
                            Console.Write("Nome da rua: ");
                            endereco.nomeRua = Console.ReadLine();
                            Console.Write("Número: ");
                            endereco.numero = Console.ReadLine();
                            Console.Write("Complemento: ");
                            endereco.complemento = Console.ReadLine();
                            Console.Write("CEP: ");
                            endereco.CEP = Console.ReadLine();
                            Console.Write("Cidade: ");
                            endereco.cidade = Console.ReadLine();
                            Console.Write("UF: ");
                            endereco.UF = Console.ReadLine();

                            cliente.endereco = endereco;

                            vetClientes[posVetor] = cliente;
                            posVetor++;
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Clientes cadastrados: \n");
                            for (int i = 0; i < posVetor; i++)
                            {
                                Console.WriteLine($"Cliente {i}: {vetClientes[i].nome}\t CPF: {vetClientes[i].CPF}\n");
                            }
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.Write("Digite o CPF do cliente que quer consultar - Utilize o formato (XXX.XXX.XXX-XX): ");
                            String buscaCPF = Console.ReadLine();
                            for (int i = 0; i < posVetor; i++)
                            {
                                if (buscaCPF == vetClientes[i].CPF)
                                {
                                    Console.WriteLine($"Nome: {vetClientes[i].nome}\t CPF: {vetClientes[i].CPF}\t Data de Nascimento: {vetClientes[i].dataNascimento}\t Idade: {vetClientes[i].idade}\t Rua: {vetClientes[i].endereco.nomeRua}\t Nº: {vetClientes[i].endereco.numero}\t Complemento: {vetClientes[i].endereco.complemento}\t CEP: {vetClientes[i].endereco.CEP}\t Cidade: {vetClientes[i].endereco.cidade}\t UF: {vetClientes[i].endereco.UF}\n");
                                }
                            }
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Digite o CPF do cliente que quer editar - Utilize o formato (XXX.XXX.XXX-XX): ");
                            String buscaCPF = Console.ReadLine();
                            for (int i = 0; i < posVetor; i++)
                            {
                                if (buscaCPF == vetClientes[i].CPF)
                                {
                                    Console.Write("Nome do cliente: ");
                                    vetClientes[i].nome = Console.ReadLine();
                                    Console.Write("CPF do cliente (XXX.XXX.XXX-XX): ");
                                    vetClientes[i].CPF = Console.ReadLine();
                                    Console.Write("Data de nascimento do cliente: ");
                                    vetClientes[i].dataNascimento = Console.ReadLine();
                                    Console.Write("Idade do cliente: ");
                                    vetClientes[i].idade = int.Parse(Console.ReadLine());
                                    Console.Write("Nome da rua: ");
                                    vetClientes[i].endereco.nomeRua = Console.ReadLine();
                                    Console.Write("Número: ");
                                    vetClientes[i].endereco.numero = Console.ReadLine();
                                    Console.Write("Complemento: ");
                                    vetClientes[i].endereco.complemento = Console.ReadLine();
                                    Console.Write("CEP: ");
                                    vetClientes[i].endereco.CEP = Console.ReadLine();
                                    Console.Write("Cidade: ");
                                    vetClientes[i].endereco.cidade = Console.ReadLine();
                                    Console.Write("UF: ");
                                    vetClientes[i].endereco.UF = Console.ReadLine();
                                }
                            }
                            Console.ReadKey();
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
    }
}
