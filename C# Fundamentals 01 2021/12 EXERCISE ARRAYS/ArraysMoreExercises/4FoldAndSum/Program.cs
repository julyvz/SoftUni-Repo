
using System;
using System.Linq;

namespace _4FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = arr.Length / 4;

            int[] row1 = new int[2 * n];
            int[] row2 = new int[2 * n];

            int indexRow2 = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                row2[indexRow2] = arr[i];
                indexRow2++;
            }
            for (int i = 0; i < 2 * n; i++)
            {
                row1[i] = arr[i + n];
            }
            for (int i = 4 * n - 1; i >= 3 * n; i--)
            {
                row2[indexRow2] = arr[i];
                indexRow2++;
            }

            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write($"{row2[i] + row1[i]} ");
            }
        }
    }
}
