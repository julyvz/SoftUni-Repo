using System;
using System.Linq;

namespace _1DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int sum1 = 0;
            int sum2 = 0;

            for (int row = 0; row < n; row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int idx1 = 0;
            int idx2 = n - 1;
            for (int row = 0; row < n; row++)
            {
                sum1 += matrix[row, idx1++];
                sum2 += matrix[row, idx2--];
            }

            Console.WriteLine(Math.Abs(sum1 - sum2));
        }
    }
}
