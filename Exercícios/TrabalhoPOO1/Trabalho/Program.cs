using System;

namespace Trabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente[] guardaContas = new ContaCorrente[50];
            int posicao = 0;
            int op;
            Double valor;

            do
            {
                Console.Clear();
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Ver Clientes Cadastrados");
                Console.WriteLine("3 - Realizar Depósito");
                Console.WriteLine("4 - Realizar Saque");
                Console.WriteLine("5 - Verificar saldo");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            Console.Clear();

                            Console.Write("Digite o nome: ");
                            String nome = Console.ReadLine();
                            Console.Write("Digite a data de nascimento: ");
                            String dataNascimento = Console.ReadLine();
                            Console.Write("Digite o endereço: ");
                            String endereço = Console.ReadLine();
                            Console.Write("Digite o CPF/CNPJ: ");
                            String documento = Console.ReadLine();

                            ContaCorrente informacoesConta = new ContaCorrente();
                            informacoesConta.nome = nome;
                            informacoesConta.dataNascimento = dataNascimento;
                            informacoesConta.endereço = endereço;
                            informacoesConta.documento = documento;

                            guardaContas[posicao] = informacoesConta;
                            posicao++;
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            for (int i = 0; i < posicao; i++)
                            {
                                Console.WriteLine("Nome: {0} \tData Nascimento: {1} \tEndereço: {2} \tDocumento: {3}", guardaContas[i].nome, guardaContas[i].dataNascimento, guardaContas[i].endereço, guardaContas[i].documento);
                            }
                            Console.WriteLine("\nPressione qualquer tecla para continuar");
                            Console.ReadKey();
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Digite o cpf/cnpj da conta");
                            String documentoDigitado = Console.ReadLine();
                            for (int i = 0; i < posicao; i++)
                            {
                                if (documentoDigitado == guardaContas[i].documento)
                                {
                                    Console.WriteLine("Digite o valor a ser depositado: ");
                                    valor = double.Parse(Console.ReadLine());
                                    guardaContas[i].Depositar(valor);
                                }
                            }
                            Console.ReadKey();
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Digite o cpf/cnpj da conta");
                            String documentoDigitado = Console.ReadLine();
                            for (int i = 0; i < posicao; i++)
                            {
                                if (documentoDigitado == guardaContas[i].documento)
                                {
                                    Console.WriteLine("Digite o valor a ser sacado: ");
                                    valor = double.Parse(Console.ReadLine());
                                    guardaContas[i].Sacar(valor);
                                }
                            }
                            Console.ReadKey();
                            break;
                        }

                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("Digite o cpf/cnpj da conta");
                            String documentoDigitado = Console.ReadLine();

                            for (int i = 0; i < posicao; i++)
                            {
                                if (documentoDigitado == guardaContas[i].documento)
                                {
                                    Double saldoDisponivel = guardaContas[i].VerSaldo();
                                    Console.Write("Seu saldo é de: {0}", saldoDisponivel);
                                }
                            }
                            Console.ReadKey();
                            break;
                        }
                    default:
                        Console.WriteLine("Valor incorreto digitado.");
                        break;
                }
            } while (op != 0);
        }
    }
}
