using System;
using System.Collections.Generic;

namespace _2Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            int n = int.Parse(tokens[0]);
            int m = int.Parse(tokens[1]);

            int[,] garden = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    garden[i, j] = 0;
                }
            }

            Stack<int> rows = new Stack<int>();
            Stack<int> cols = new Stack<int>();
            string input;
            while ((input = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                tokens = input.Split();
                int x = int.Parse(tokens[0]);
                int y = int.Parse(tokens[1]);
                if (x < 0 || x >= n || y < 0 || y >= m)
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }
                rows.Push(x);
                cols.Push(y);
            }

            while (rows.Count > 0)
            {
                int x = rows.Pop();
                int y = cols.Pop();
                for (int col = 0; col < m; col++)
                {
                    garden[x, col]++;
                }
                for (int row = 0; row < n; row++)
                {
                    garden[row, y]++;
                }
                garden[x, y]--;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{garden[i, j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
