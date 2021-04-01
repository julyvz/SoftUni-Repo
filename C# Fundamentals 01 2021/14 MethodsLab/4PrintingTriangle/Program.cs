using System;

namespace _4PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);
        }

        static void PrintTriangle(int n)
        {
            int k = 0;
            for (int i = 1; i < 2 * n; i++)
            {
                if (i <= n)
                {
                    k++;
                }
                else
                {
                    k--;
                }

                for (int j = 1; j <= k; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
