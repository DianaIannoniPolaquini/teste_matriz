using System;

namespace DESAFIO_MATRIZ_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a quantidade de linhas: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a quantidade de colunas: ");
            int y = int.Parse(Console.ReadLine());

            int[,] mat = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < y; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("Entre com 1 valor inteiro da matriz: ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (mat[i, j] == a)
                    {
                        Console.WriteLine($"Posição {i}, {j}.");
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                        }
                        if (j < y - 1)
                        {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }
                        if (i < x - 1)
                        {
                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
