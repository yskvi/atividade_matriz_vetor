using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
                int[,] mat =
                {
        { 1, 42, 23, 14, 51 },
        { 22, 32, 55, 54, 12 }
    };

                Console.WriteLine("\nExibindo apenas os elementos pares da matriz:\n");

                for (int x = 0; x < 2; x++)
                {
                    for (int y = 0; y < 5; y++)
                    {
                        if (mat[x, y] % 2 == 0)
                            Console.Write($" {mat[x, y]:D2} ");
                        else
                            Console.Write(" -- ");
                    }
                    Console.WriteLine();
                }

                Console.ReadKey();
            }

        }
    }
