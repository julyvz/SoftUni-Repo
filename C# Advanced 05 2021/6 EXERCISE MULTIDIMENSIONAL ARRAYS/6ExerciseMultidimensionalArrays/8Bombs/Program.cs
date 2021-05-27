using System;
using System.Linq;

namespace _8Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            // populate the matrix
            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }

            string[] coordinates = Console.ReadLine().Split();
            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] xy = coordinates[i].Split(',').Select(int.Parse).ToArray();
                int row = xy[0];
                int col = xy[1];
                int currentBombStrength = matrix[row, col];

                // bomb explodes
                if (currentBombStrength > 0)
                {
                    for (int ii = row - 1; ii <= row + 1; ii++)
                    {
                        for (int jj = col - 1; jj <= col + 1; jj++)
                        {
                            try
                            {
                                if (matrix[ii, jj] > 0)
                                {
                                    matrix[ii, jj] -= currentBombStrength;
                                }
                            }
                            catch (Exception)
                            {
                                continue;
                            }
                        }
                    }
                }
            }

            // print active cells

            int aliveCells = 0;
            int sumOfCells = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        aliveCells++;
                        sumOfCells += matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sumOfCells}");

            // print the matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
