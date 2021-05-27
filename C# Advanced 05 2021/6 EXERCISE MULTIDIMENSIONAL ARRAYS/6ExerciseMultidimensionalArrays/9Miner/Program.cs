using System;
using System.Linq;

namespace _9Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] commands = Console.ReadLine().Split();

            char[,] field = new char[n, n];
            int startRow = 0;
            int startCol = 0;
            int totalCoals = 0;

            // populate the field
            for (int i = 0; i < n; i++)
            {
                char[] arr = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    field[i, j] = arr[j];
                    if (field[i, j] == 'c')
                    {
                        totalCoals++;
                    }
                    else if (field[i, j] == 's')
                    {
                        startRow = i;
                        startCol = j;
                    }
                }
            }

            int currentRow = startRow;
            int currentCol = startCol;

            for (int i = 0; i < commands.Length; i++)
            {
                string command = commands[i];
                if (validMove(currentRow, currentCol, command, n))
                {
                    switch (command)
                    {
                        case "up":
                            currentRow--;
                            break;
                        case "down":
                            currentRow++;
                            break;
                        case "left":
                            currentCol--;
                            break;
                        case "right":
                            currentCol++;
                            break;
                    }

                    switch (field[currentRow, currentCol])
                    {
                        case '*':
                            break;
                        case 's':
                            break;
                        case 'c':
                            totalCoals--;
                            field[currentRow, currentCol] = '*';
                            if (totalCoals == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                return;
                            }
                            break;
                        case 'e':
                            Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                            return;
                            break;
                    }
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine($"{totalCoals} coals left. ({currentRow}, {currentCol})");
        }

        private static bool validMove(int currentRow, int currentCol, string command, int n)
        {
            bool isValid = false;
            switch (command)
            {
                case "up":
                    if (currentRow - 1 >= 0)
                    {
                        isValid = true;
                    }
                    break;
                case "down":
                    if (currentRow + 1 < n)
                    {
                        isValid = true;
                    }
                    break;
                case "left":
                    if (currentCol - 1 >= 0)
                    {
                        isValid = true;
                    }
                    break;
                case "right":
                    if (currentCol + 1 < n)
                    {
                        isValid = true;
                    }
                    break;
            }
            return isValid;
        }
    }
}
