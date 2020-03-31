using System;

namespace SistemaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosAluno[] vetorAlunos = new DadosAluno[50];
            int posicaoVetor = 0;
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("0 - Sair do sistema");
                Console.WriteLine("1 - Inserir alunos no sistema");
                Console.WriteLine("2 - Listar todos os alunos");
                Console.WriteLine("3 - Listar todos os alunos aprovados");
                Console.WriteLine("4 - Listar todos os alunos reprovados");
                Console.WriteLine("5 - Editar aluno");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Sistema encerrado, pressione uma tecla para fechar.");
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.Clear();
                        String nome, RA, idade, notaB1, notaB2, mediaFinal;
                        Console.WriteLine("* Inserir Aluno *");
                        Console.Write("Digite o nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Digite o RA: ");
                        RA = Console.ReadLine();
                        Console.Write("Digite a idade: ");
                        idade = Console.ReadLine();
                        Console.Write("Digite a nota B1: ");
                        notaB1 = Console.ReadLine();
                        Console.Write("Digite a nota B2: ");
                        notaB2 = Console.ReadLine();
                        Console.Write("Digite a media final: ");
                        mediaFinal = Console.ReadLine();
                        DadosAluno infAluno = new DadosAluno();
                        infAluno.nome = nome;
                        infAluno.RA = RA;
                        infAluno.idade = int.Parse(idade);
                        infAluno.notaB1 = Double.Parse(notaB1);
                        infAluno.notaB2 = Double.Parse(notaB2);
                        infAluno.mediaFinal = Double.Parse(mediaFinal);
                        Console.WriteLine("\nAluno cadastrado com sucesso!\n");
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
                        vetorAlunos[posicaoVetor] = infAluno;
                        posicaoVetor++;
                        break;
                    case 2:
                        Console.Clear();
                        String auxNome;
                        String auxRA;
                        int auxI = 0;
                        Double auxB1 = 0;
                        Double auxB2 = 0;
                        Double auxM = 0;

                        for (int x = 0; x < posicaoVetor; x++)
                        {
                            for (int y = x + 1; y < posicaoVetor; y++) 
                            {
                                if (vetorAlunos[y].mediaFinal > vetorAlunos[x].mediaFinal)
                                {
                                    auxNome = vetorAlunos[y].nome;
                                    vetorAlunos[y].nome = vetorAlunos[x].nome;
                                    vetorAlunos[x].nome = auxNome;

                                    auxRA = vetorAlunos[y].RA;
                                    vetorAlunos[y].RA = vetorAlunos[x].RA;
                                    vetorAlunos[x].RA = auxRA;

                                    auxI = vetorAlunos[y].idade;
                                    vetorAlunos[y].idade = vetorAlunos[x].idade;
                                    vetorAlunos[x].idade = auxI;

                                    auxB1 = vetorAlunos[y].notaB1;
                                    vetorAlunos[y].notaB1 = vetorAlunos[x].notaB1;
                                    vetorAlunos[x].notaB1 = auxB1;

                                    auxB2 = vetorAlunos[y].notaB2;
                                    vetorAlunos[y].notaB2 = vetorAlunos[x].notaB2;
                                    vetorAlunos[x].notaB2 = auxB2;

                                    auxM = vetorAlunos[y].mediaFinal;
                                    vetorAlunos[y].mediaFinal = vetorAlunos[x].mediaFinal;
                                    vetorAlunos[x].mediaFinal = auxM;
                                }
                            }
                        }

                        for (int i = 0; i < posicaoVetor; i++)
                        {
                            Console.WriteLine("Nome: {0} \tRA: {1} \tIdade: {2} \tNotaB1: {3} \tNotaB2: {4} \tMediaFinal: {5}", vetorAlunos[i].nome, vetorAlunos[i].RA, vetorAlunos[i].idade, vetorAlunos[i].notaB1, vetorAlunos[i].notaB1, vetorAlunos[i].mediaFinal);
                        }

                        Console.WriteLine("\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Clear();
                        for (int i = 0; i < posicaoVetor; i++)
                        {
                            if (vetorAlunos[i].mediaFinal >= 5.0)
                            {
                                Console.WriteLine("Nome: {0} \tRA: {1} \tIdade: {2} \tNotaB1: {3} \tNotaB2: {4} \tMediaFinal: {5}", vetorAlunos[i].nome, vetorAlunos[i].RA, vetorAlunos[i].idade, vetorAlunos[i].notaB1, vetorAlunos[i].notaB1, vetorAlunos[i].mediaFinal);
                            }
                        }
                        Console.WriteLine("\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        for (int i = 0; i < posicaoVetor; i++)
                        {
                            if (vetorAlunos[i].mediaFinal < 5.0)
                            {
                                Console.WriteLine("Nome: {0} \tRA: {1} \tIdade: {2} \tNotaB1: {3} \tNotaB2: {4} \tMediaFinal: {5}", vetorAlunos[i].nome, vetorAlunos[i].RA, vetorAlunos[i].idade, vetorAlunos[i].notaB1, vetorAlunos[i].notaB1, vetorAlunos[i].mediaFinal);
                            }
                        }
                        Console.WriteLine("\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("Insira o RA do aluno que deseja editar as informações: ");
                        String buscaRA = Console.ReadLine();

                        for (int j = 0; j < posicaoVetor; j++)
                        {
                            if (buscaRA == vetorAlunos[j].RA)
                            {
                                String nomeEditar, RAEditar, idadeEditar, notaB1Editar, notaB2Editar, mediaFinalEditar;
                                DadosAluno infAlunoEditar = new DadosAluno();

                                Console.WriteLine("Aluno encontrado, altere as informações:");
                                Console.Write("Digite o nome: ");
                                nomeEditar = Console.ReadLine();
                                Console.Write("Digite o RA: ");
                                RAEditar = Console.ReadLine();
                                Console.Write("Digite a idade: ");
                                idadeEditar = Console.ReadLine();
                                Console.Write("Digite a nota B1: ");
                                notaB1Editar = Console.ReadLine();
                                Console.Write("Digite a nota B2: ");
                                notaB2Editar = Console.ReadLine();
                                Console.Write("Digite a media final: ");
                                mediaFinalEditar = Console.ReadLine();
                                infAlunoEditar.nome = nomeEditar;
                                infAlunoEditar.RA = RAEditar;
                                infAlunoEditar.idade = int.Parse(idadeEditar);
                                infAlunoEditar.notaB1 = Double.Parse(notaB1Editar);
                                infAlunoEditar.notaB2 = Double.Parse(notaB2Editar);
                                infAlunoEditar.mediaFinal = Double.Parse(mediaFinalEditar);

                                vetorAlunos[j] = infAlunoEditar;
                                Console.WriteLine("Informações editadas com sucesso!");
                                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
                            }
                            else
                            {
                                Console.WriteLine("RA não cadastrado no sistema, pressiona qualquer tecla para voltar ao menu.");
                                Console.ReadKey();
                            }
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ocorreu um erro, parece que nenhuma tecla válida foi pressionada");
                        Console.WriteLine("\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                }
            } while (op != 0);
        }
    }
}
