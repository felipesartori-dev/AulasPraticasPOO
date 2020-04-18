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
                            Console.WriteLine("Cliente conta especial ? (Y/N)");
                            char especial = char.Parse(Console.ReadLine());
                            if (especial == 'Y' || especial == 'y')
                            {
                                ContaCorrente contaClienteEspecial = new ContaEspecial();

                                Console.Write("Insira o nome: ");
                                contaClienteEspecial.Nome = Console.ReadLine();
                                Console.Write("Insira o cpf: ");
                                contaClienteEspecial.Cpf = Console.ReadLine();

                                contaClienteEspecial.TipoConta = "Especial";

                                bancoCliente.insereNovoCliente(contaClienteEspecial);
                            }
                            else
                            {
                                ContaCorrente contaClienteNormal = new ContaCorrente();

                                Console.Write("Insira o nome: ");
                                contaClienteNormal.Nome = Console.ReadLine();
                                Console.Write("Insira o cpf: ");
                                contaClienteNormal.Cpf = Console.ReadLine();

                                contaClienteNormal.TipoConta = "Conta normal";

                                bancoCliente.insereNovoCliente(contaClienteNormal);
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            for (int i = 0; i < bancoCliente.getQuantiaClientes(); i++)
                            {
                                if (bancoCliente.getCliente(i).TipoConta == "Especial")
                                {
                                    Console.WriteLine($"\nNome: \t{bancoCliente.getCliente(i).Nome}\nCpf: \t{bancoCliente.getCliente(i).Cpf}\nTipo: \t{bancoCliente.getCliente(i).TipoConta}\nSaldo: \t{bancoCliente.getCliente(i).Saldo}\nLimite: {((ContaEspecial)bancoCliente.getCliente(i)).ConsultarLimite()}\t");
                                }
                                else
                                {
                                    Console.WriteLine($"\nNome: {bancoCliente.getCliente(i).Nome}\nCpf: {bancoCliente.getCliente(i).Cpf}\nTipo conta: {bancoCliente.getCliente(i).TipoConta}\nSaldo: {bancoCliente.getCliente(i).Saldo}\n");
                                }
                            }
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.Write("Digite o CPF da conta:");
                            String CPF = Console.ReadLine();
                            for (int i = 0; i < bancoCliente.getQuantiaClientes(); i++)
                            {
                                if (bancoCliente.getCliente(i).Cpf == CPF)
                                {
                                    Console.WriteLine("Insira o valor do deposito:");
                                    double valorDeposito = Double.Parse(Console.ReadLine());
                                    bancoCliente.getCliente(i).Depositar(valorDeposito);
                                    Console.WriteLine("Saldo atualizado:" + bancoCliente.getCliente(i).VerSaldo());
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
                                    bancoCliente.getCliente(i).Sacar(valorSaque);
                                    Console.WriteLine("Saldo atualizado:" + bancoCliente.getCliente(i).VerSaldo());
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
                                    ((ContaEspecial)bancoCliente.getCliente(i)).AumentarLimite(valor);
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
                                    ((ContaEspecial)bancoCliente.getCliente(i)).DiminuirLimite(valor);
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
