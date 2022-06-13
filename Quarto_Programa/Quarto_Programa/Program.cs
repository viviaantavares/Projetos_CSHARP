﻿// fazer um programa para ler dois números inteiros M e N, e depois ler uma matriz de M linhas por n colunas contendo números inteiros,
// podendo haver repetições. Em seguida, ler um número inteiro X que pertence à matriz. Para cada ocorrência de X, mostrar os valores
// à esquerda, acima, à direita e abaixo de X, quando houver, conforme exemplo. 

using System;
using System.Globalization;

namespace Quarto_Programa
{
    class Program
    {
        static void Main(string[] args)

        {
            string [] linha = Console.ReadLine().Split(' ');
            int m = int.Parse(linha[0]);
            int n = int.Parse(linha[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for(int j = 0; i < n; j++)
                {
                    if (mat[i,j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ": ");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i < 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }

    }

}