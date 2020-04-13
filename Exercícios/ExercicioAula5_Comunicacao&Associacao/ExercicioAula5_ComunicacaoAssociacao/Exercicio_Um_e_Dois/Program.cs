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
            DadosClientes dados = new DadosClientes();
            BancoClientes guardaCliente = new BancoClientes();
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
                            dados.PegaDados(cliente, endereco);
                            guardaCliente.gravaCliente(cliente);
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Clientes cadastrados: \n");
                            for (int i = 0; i < guardaCliente.getQuantiaClientes(); i++)
                            {
                                Console.WriteLine($"Cliente {i}: {guardaCliente.getCliente(i).Nome}\t CPF: {guardaCliente.getCliente(i).Cpf}\n");
                            }
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.Write("Digite o CPF do cliente que quer consultar - Utilize o formato (XXX.XXX.XXX-XX): ");
                            String buscaCPF = Console.ReadLine();
                            for (int i = 0; i < guardaCliente.getQuantiaClientes(); i++)
                            {
                                if (buscaCPF == guardaCliente.getCliente(i).Cpf)
                                {
                                    Console.WriteLine($"Nome: {guardaCliente.getCliente(i).Nome}\t CPF: {guardaCliente.getCliente(i).Cpf}\t Data de Nascimento: {guardaCliente.getCliente(i).DataNascimento}\t Idade: {guardaCliente.getCliente(i).Idade}\t Rua: {guardaCliente.getCliente(i).Endereco.NomeRua}\t Nº: {guardaCliente.getCliente(i).Endereco.Numero}\t Complemento: {guardaCliente.getCliente(i).Endereco.Complemento}\t CEP: {guardaCliente.getCliente(i).Endereco.Cep}\t Cidade: {guardaCliente.getCliente(i).Endereco.Cidade}\t UF: {guardaCliente.getCliente(i).Endereco.Uf}\n");
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
                            dados.EditaClientes(guardaCliente, buscaCPF);
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
