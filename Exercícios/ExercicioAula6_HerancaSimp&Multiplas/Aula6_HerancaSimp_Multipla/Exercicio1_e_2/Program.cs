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

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        {

                        }
                        break;                    
                    case 1:
                        {
                            Console.Clear();
                            ContaCorrente contaCliente = new ContaCorrente();
                            ContaCorrente realizaFuncao = new ContaCorrente();

                            Console.Write("Insira o nome: ");
                            contaCliente.Nome = Console.ReadLine();
                            Console.Write("Insira o cpf: ");
                            contaCliente.Cpf = Console.ReadLine();

                            bancoCliente.insereNovoCliente(contaCliente);
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            for (int i = 0; i < bancoCliente.getQuantiaClientes(); i++)
                            {
                                Console.WriteLine($"\nNome: {bancoCliente.getCliente(i).Nome}\nCpf: {bancoCliente.getCliente(i).Cpf}\nSaldo: {bancoCliente.getCliente(i).Saldo}\n");
                            }
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        {
                            realizaFuncao = new ContaEspecial();
                            Console.Clear();
                            Console.Write("Digite o CPF da conta:");
                            String CPF = Console.ReadLine();
                            for (int i = 0; i < bancoCliente.getQuantiaClientes(); i++)
                            {
                                if (bancoCliente.getCliente(i).Cpf == CPF)
                                {
                                    Console.WriteLine("Insira o valor do deposito:");
                                    double valorDeposito = Double.Parse(Console.ReadLine());
                                    realizaFuncao.Depositar(valorDeposito);
                                    bancoCliente.getCliente(i).Saldo = realizaFuncao.VerSaldo();
                                }
                            }  
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Console.Write("Digite o CPF da conta:");
                            String CPF = Console.ReadLine();
                            for (int i = 0; i < bancoCliente.getQuantiaClientes(); i++)
                            {
                                if (bancoCliente.getCliente(i).Cpf == CPF)
                                {
                                    Console.WriteLine("Insira o valor do saque:");
                                    double valorSaque = Double.Parse(Console.ReadLine());
                                    realizaFuncao.Sacar(valorSaque);
                                    bancoCliente.getCliente(i).Saldo = realizaFuncao.VerSaldo();
                                }
                            }
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida digitada, tente novamente.");
                        Console.ReadKey();
                        break;
                }

            } while (op != 0);
        }
    }
}
