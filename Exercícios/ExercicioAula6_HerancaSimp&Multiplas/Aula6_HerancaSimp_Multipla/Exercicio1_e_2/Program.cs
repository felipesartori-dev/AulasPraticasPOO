using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_e_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BancoClientes bancoCliente = new BancoClientes();
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("      ** Menu **\n\n");
                Console.WriteLine("0 - Sair do sistema");
                Console.WriteLine("1 - Inserir Cliente");
                Console.WriteLine("2 - Exibir Clientes");
                Console.WriteLine("3 - Realizar Deposito");
                Console.WriteLine("4 - Realizar Saque");
                Console.WriteLine("5 - Aumentar Limite");
                Console.WriteLine("6 - Diminuir Limite");
                Console.WriteLine("7 - Consultar Limite");


                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        {
                            Console.WriteLine("O sistema será encerrado.");
                        }
                        break;
                    case 1:
                        {
                            Console.Clear();
                            ContaEspecial contaClienteEspecial = new ContaEspecial();

                            Console.Write("Insira o nome: ");
                            contaClienteEspecial.Nome = Console.ReadLine();
                            Console.Write("Insira o cpf: ");
                            contaClienteEspecial.Cpf = Console.ReadLine();

                            bancoCliente.insereNovoCliente(contaClienteEspecial);
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            for (int i = 0; i < bancoCliente.getQuantiaClientes(); i++)
                            {
                                Console.WriteLine($"\nNome: \t{bancoCliente.getCliente(i).Nome}\nCpf: \t{bancoCliente.getCliente(i).Cpf}\nSaldo: \t{bancoCliente.getCliente(i).Saldo}\n");
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.Write("Digite o CPF da conta: ");
                            String CPF = Console.ReadLine();
                            for (int i = 0; i < bancoCliente.getQuantiaClientes(); i++)
                            {
                                if (bancoCliente.getCliente(i).Cpf == CPF)
                                {
                                    Console.Write("Insira o valor do deposito: ");
                                    double valorDeposito = Double.Parse(Console.ReadLine());
                                    bancoCliente.getCliente(i).Depositar(valorDeposito);
                                    Console.WriteLine("Saldo atual: " + bancoCliente.getCliente(i).VerSaldo());
                                }
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Console.Write("Digite o CPF da conta: ");
                            String CPF = Console.ReadLine();
                            for (int i = 0; i < bancoCliente.getQuantiaClientes(); i++)
                            {
                                if (bancoCliente.getCliente(i).Cpf == CPF)
                                {
                                    Console.Write("Insira o valor do saque: ");
                                    double valorSaque = Double.Parse(Console.ReadLine());
                                    bancoCliente.getCliente(i).Sacar(valorSaque);
                                    Console.WriteLine("Saldo atual: " + bancoCliente.getCliente(i).VerSaldo());
                                }
                            }
                        }
                        break;
                    case 5:
                        {
                            Console.Clear();
                            Console.Write("Digite o CPF da conta que deseja aumentar o limite: ");
                            string buscaCPF = Console.ReadLine();
                            for (int i = 0; i < bancoCliente.getQuantiaClientes(); i++)
                            {
                                if (bancoCliente.getCliente(i).Cpf == buscaCPF)
                                {
                                    Console.Write("Digite o valor: ");
                                    Double valor = double.Parse(Console.ReadLine());
                                    bancoCliente.getCliente(i).AumentarLimite(valor);
                                }
                            }
                        }
                        break;
                    case 6:
                        {
                            Console.Clear();
                            Console.Write("Digite o CPF da conta que deseja diminuir o limite: ");
                            string buscaCPF = Console.ReadLine();
                            for (int i = 0; i < bancoCliente.getQuantiaClientes(); i++)
                            {
                                if (bancoCliente.getCliente(i).Cpf == buscaCPF)
                                {
                                    Console.Write("Digite o valor:");
                                    Double valor = double.Parse(Console.ReadLine());
                                    bancoCliente.getCliente(i).DiminuirLimite(valor);
                                }
                            }
                        }
                        break;
                    case 7:
                        {
                            Console.Clear();
                            Console.Write("Digite o CPF da conta que deseja verificar o limite: ");
                            string buscaCPF = Console.ReadLine();
                            for (int i = 0; i < bancoCliente.getQuantiaClientes(); i++)
                            {
                                if (bancoCliente.getCliente(i).Cpf == buscaCPF)
                                {
                                    Console.Write($"O limite atual é de: {bancoCliente.getCliente(i).ConsultarLimite()}");
                                }
                            }
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida digitada, tente novamente.");
                        break;
                }
                Console.ReadKey();
            } while (op != 0);
        }
    }
}
