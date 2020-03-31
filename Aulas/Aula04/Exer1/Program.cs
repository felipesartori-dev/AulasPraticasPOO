using System;

namespace Exer1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaIdade guardaIdade = new ListaIdade();
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Adicionar idade");
                Console.WriteLine("2 - Atualizar idade");
                Console.WriteLine("3 - Ver lista das idades registradas");
                Console.WriteLine("4 - Ver lista das idades registradas em ordem crescente");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        {
                            Console.Clear();
                            Console.WriteLine("Programa encerrado");
                        }
                        break;

                    case 1:
                        {
                            Console.Clear();
                            int idade;

                            Console.WriteLine("Digite a idade para registrar: ");

                            while (!int.TryParse(Console.ReadLine(), out idade))
                            {
                                Console.WriteLine("Foi passado um valor incorreto, tente novamente.");
                            }

                            guardaIdade.AdicionarIdade(idade); 
                        }
                        break;

                    case 2:
                        {
                            Console.Clear();

                            Console.WriteLine("Digite o índice da idade que quer alterar:");
                            int indAtt;

                            while (!int.TryParse(Console.ReadLine(), out indAtt) || indAtt > guardaIdade.quantidade)
                            {
                                Console.WriteLine("Índice não existente");
                            }

                            Console.WriteLine("Digite a idade para registrar:");
                            int idadeAtt;

                            while (!int.TryParse(Console.ReadLine(), out idadeAtt))
                            {
                                Console.WriteLine("Foi passado um valor incorreto, tente novamente.");
                            }

                            guardaIdade.AtualizarIdade(indAtt, idadeAtt);
                        }
                        break;

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("As idades registradas até o momento são:\n");
                            guardaIdade.GetListIdades();
                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        {
                            Console.Clear();
                            guardaIdade.GetListOrdenadaIdades();
                            Console.ReadKey();
                        }
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Valor incorreto digitado");
                        Console.ReadKey();
                        break;
                }
            } while (op != 0);
        }
    }
}
