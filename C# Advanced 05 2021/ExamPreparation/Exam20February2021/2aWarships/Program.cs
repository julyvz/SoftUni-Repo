using System;
using System.Collections.Generic;
using System.Linq;

namespace _2Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> attacks = new Queue<string>(Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries));

            char[,] field = new char[n, n];
            int shipsOfFirst = 0;
            int shipsOfSecond = 0;
            bool hasWinner = false;

            for (int i = 0; i < n; i++)
            {                
                char[] temp = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int j = 0; j < n; j++)
                {
                    field[i, j] = temp[j];
                    if (field[i, j] == '<')
                    {
                        shipsOfFirst++;
                    }
                    else if (field[i, j] == '>')
                    {
                        shipsOfSecond++;
                    }
                }
            }

            int totalNewShips = shipsOfFirst + shipsOfSecond;

            while (attacks.Count > 0 && !hasWinner)
            {
                string[] tokens = attacks.Dequeue().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int currRow = int.Parse(tokens[0]);
                int currCol = int.Parse(tokens[1]);

                if (currRow < 0 || currRow >= n || currCol < 0 || currCol >= n)
                {
                    continue;
                }

                switch (field[currRow, currCol])
                {
                    case '<':
                        field[currRow, currCol] = 'X';
                        shipsOfFirst--;
                        break;

                    case '>':
                        field[currRow, currCol] = 'X';
                        shipsOfSecond--;
                        break;

                    case '#':
                        field[currRow, currCol] = 'X';
                        for (int i = currRow - 1; i <= currRow + 1; i++)
                        {
                            for (int j = currCol - 1; j <= currCol + 1; j++)
                            {
                                if (i < 0 || i >= n || j < 0 || j >= n)
                                {
                                    continue;
                                }

                                switch (field[i, j])
                                {
                                    case '<':
                                        field[i, j] = 'X';
                                        shipsOfFirst--;
                                        break;

                                    case '>':
                                        field[i, j] = 'X';
                                        shipsOfSecond--;
                                        break;
                                }
                            }
                        }
                        break;
                }

                if (shipsOfFirst == 0 || shipsOfSecond == 0)
                {
                    hasWinner = true;
                }
            }

            if (hasWinner)
            {
                if (shipsOfSecond == 0)
                {
                    Console.WriteLine($"Player One has won the game! {totalNewShips - shipsOfFirst - shipsOfSecond} ships have been sunk in the battle.");
                }
                else
                {
                    Console.WriteLine($"Player Two has won the game! {totalNewShips - shipsOfFirst - shipsOfSecond} ships have been sunk in the battle.");
                }
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {shipsOfFirst} ships left. Player Two has {shipsOfSecond} ships left.");
            }
        }
    }
}
