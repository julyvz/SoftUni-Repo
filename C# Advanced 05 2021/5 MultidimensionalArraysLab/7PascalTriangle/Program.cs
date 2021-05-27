using System;

namespace _7PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] triangle = new long[n][];
            int currentWidth = 1;

            for (int row = 0; row < n; row++)
            {
                triangle[row] = new long[currentWidth];
                long[] currentRow = triangle[row];
                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;
                currentWidth++;
            }

            for (int row = 2; row < n; row++)
            {
                for (int col = 1; col < row; col++)
                {
                    triangle[row][col] = triangle[row - 1][col] + triangle[row - 1][col - 1];
                }
            }

            foreach (var row in triangle)
            {
                Console.WriteLine(string.Join(' ', row));
            }
        }
    }
}
