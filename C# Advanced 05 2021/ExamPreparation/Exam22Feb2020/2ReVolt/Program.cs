using System;

namespace _2ReVolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] board = new char[n, n];
            int row = 0;
            int col = 0;
            int oldRow = 0;
            int oldCol = 0;
            bool hasWon = false;

            int countOfCommands = int.Parse(Console.ReadLine());

            // initialize the board
            for (int i = 0; i < n; i++)
            {
                char[] temp = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = temp[j];
                    if (board[i, j] == 'f')
                    {
                        row = i;
                        col = j;
                    }
                }
            }

            for (int i = 0; i < countOfCommands; i++)
            {
                string direction = Console.ReadLine();
                board[row, col] = '-';
                oldRow = row;
                oldCol = col;
                switch (direction)
                {
                    case "up":
                        row--;
                        if (row < 0)
                        {
                            row = n - 1;
                        }
                        break;

                    case "down":
                        row++;
                        if (row > n - 1)
                        {
                            row = 0;
                        }
                        break;

                    case "left":
                        col--;
                        if (col < 0)
                        {
                            col = n - 1;
                        }
                        break;

                    case "right":
                        col++;
                        if (col > n - 1)
                        {
                            col = 0;
                        }
                        break;
                }

                if (board[row, col] == 'F')
                {
                    hasWon = true;
                    board[row, col] = 'f';
                    break;
                }
                else if (board[row, col] == 'B')
                {
                    switch (direction)
                    {
                        case "up":
                            row--;
                            if (row < 0)
                            {
                                row = n - 1;
                            }
                            break;

                        case "down":
                            row++;
                            if (row > n - 1)
                            {
                                row = 0;
                            }
                            break;

                        case "left":
                            col--;
                            if (col < 0)
                            {
                                col = n - 1;
                            }
                            break;

                        case "right":
                            col++;
                            if (col > n - 1)
                            {
                                col = 0;
                            }
                            break;
                    }

                    if (board[row, col] == 'F')
                    {
                        hasWon = true;
                        board[row, col] = 'f';
                        break;
                    }

                }
                else if (board[row, col] == 'T')
                {
                    row = oldRow;
                    col = oldCol;
                }

                board[row, col] = 'f';
            }

            if (hasWon)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            // print
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(board[i, j]);
                }
                if (i != n - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
