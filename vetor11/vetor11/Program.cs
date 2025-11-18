using System;

namespace MyApp
{
    internal class Program
    {
            static void Main(string[] args)
            {
                const int QTD_COL = 3; 
                const int QTD_LIN = 5;

                double[,] notas = new double[QTD_LIN, QTD_COL];

                notas = cadastrarNotas(QTD_LIN, QTD_COL);

                Console.WriteLine("\n *** Notas cadastradas na Matriz ***\n");
                exibirDados(notas);

                Console.ReadKey();
            }
            static double[,] cadastrarNotas(int nLin, int nCol)
            {
                double[,] n = new double[nLin, nCol];

                for (int l = 0; l < nLin; l++)
                {
                    Console.WriteLine($"\nNotas do {l + 1}º aluno");

                    for (int c = 0; c < nCol; c++)
                    {
                        Console.Write($" {c + 1}º nota: ");
                        n[l, c] = double.Parse(Console.ReadLine());
                    }
                }

                return n;
            }


            static void exibirDados(double[,] nt)
            {
                Console.WriteLine("\nAluno \t\tNota1 \t\tNota2 \t\tNota3 \n");

                for (int i = 0; i < nt.GetLength(0); i++)
                {
                    Console.Write($"{i + 1}ºAluno: ");

                    for (int j = 0; j < nt.GetLength(1); j++)
                    {
                        Console.Write($"\t{nt[i, j]:0.0}\t");
                    }

                    Console.WriteLine();
                }
            }
        }

    }


