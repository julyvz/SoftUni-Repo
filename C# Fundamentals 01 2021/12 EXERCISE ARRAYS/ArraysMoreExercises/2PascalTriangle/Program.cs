using System;

namespace _2PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] previousArr = new int[n];

            for (int row = 1; row <= n; row++)
            {
                int[] currentArr = new int[row];

                currentArr[0] = 1;
                for (int j = 1; j < row; j++)
                {
                    currentArr[j] = previousArr[j] + previousArr[j - 1];
                }
                for (int i = 0; i < row; i++)
                {
                    previousArr[i] = currentArr[i];
                }
                Console.WriteLine(String.Join(' ', currentArr));
            }
        }
    }
}
