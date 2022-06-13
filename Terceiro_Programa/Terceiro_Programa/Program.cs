// fazer um programa para ler um número inteiro N e uma matriz de ordem N contendo números inteiros. Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz.

using System;
using System.Globalization;

namespace Primeiro_Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // [,] indica o inicio da matriz
            // mat é o nome da variável
            // [n, n] n = linhas 
            //        n = colunas

            int[,] mat = new int[n, n];

            // for com o intuito de percorrer as linhas
            for (int i = 0; i < n; i++)
            {
                // vetor de string 
                string[] values = Console.ReadLine().Split(' ');

                // for com o intuito de percorrer as colunas
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
               
                }
               
            }
            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");  
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);



        }
    }

}


