using System;

namespace _10RadioactiveBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split();
            int n = int.Parse(dimensions[0]);
            int m = int.Parse(dimensions[1]);

            char[,] lair = new char[n, m];

            int currentRow = 0;
            int currentCol = 0;
            int lastRow = 0;
            int lastCol = 0;
            bool hasWon = false;

            // populate
            for (int row = 0; row < n; row++)
            {
                char[] arr = Console.ReadLine().ToCharArray();
                for (int col = 0; col < m; col++)
                {
                    lair[row, col] = arr[col];
                    if (lair[row, col] == 'P')
                    {
                        currentRow = row;
                        currentCol = col;
                        lair[row, col] = '.';
                    }
                }
            }

            string command = Console.ReadLine();

            for (int i = 0; i < command.Length; i++)
            {
                char currentMove = command[i];
                switch (currentMove)
                {
                    case 'U':
                        lastRow = currentRow;
                        lastCol = currentCol;
                        currentRow--;
                        break;
                    case 'D':
                        lastRow = currentRow;
                        lastCol = currentCol;
                        currentRow++;
                        break;
                    case 'L':
                        lastRow = currentRow;
                        lastCol = currentCol;
                        currentCol--;
                        break;
                    case 'R':
                        lastRow = currentRow;
                        lastCol = currentCol;
                        currentCol++;
                        break;
                }

                //bunny spread
                for (int ii = 0; ii < n; ii++)
                {
                    for (int jj = 0; jj < m; jj++)
                    {
                        if (lair[ii, jj] == 'B')
                        {
                            if (ii - 1 >= 0 && lair[ii - 1, jj] != 'B') lair[ii - 1, jj] = 'S';
                            if (ii + 1 < n && lair[ii + 1, jj] != 'B') lair[ii + 1, jj] = 'S';
                            if (jj - 1 >= 0 && lair[ii, jj - 1] != 'B') lair[ii, jj - 1] = 'S';
                            if (jj + 1 < m && lair[ii, jj + 1] != 'B') lair[ii, jj + 1] = 'S';
                        }
                    }
                }
                for (int ii = 0; ii < n; ii++)
                {
                    for (int jj = 0; jj < m; jj++)
                    {
                        if (lair[ii, jj] == 'S')
                        {
                            lair[ii, jj] = 'B';
                        }
                    }
                }

                if (currentRow < 0 || currentRow >= n || currentCol < 0 || currentCol >= m)
                {
                    hasWon = true;
                    break;
                }

                if (lair[currentRow, currentCol] == 'B')
                {
                    break;
                }
            }

            // print lair
            PrintLair(n, m, lair);

            if (hasWon)
            {
                Console.WriteLine($"won: {lastRow} {lastCol}");
            }
            else
            {
                Console.WriteLine($"dead: {currentRow} {currentCol}");
            }
        }

        private static void PrintLair(int n, int m, char[,] lair)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(lair[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
