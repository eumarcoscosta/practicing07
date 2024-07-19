using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int m, n;
            int[,] matriz;

            Console.WriteLine("Insira o numero abaixo: ");

            string[] vet = Console.ReadLine().Split(' ');
            m = int.Parse(vet[0]);
            n = int.Parse(vet[1]);

            matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(vet[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}