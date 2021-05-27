using System;
using System.Linq;

namespace _9aMiner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] field = new char[n, n];

            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int startRow = 0;
            int startCol = 0;
            int totalCoals = 0;

            for (int row = 0; row < n; row++)
            {
                char[] arr = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    field[row, col] = arr[col];
                    if (field[row, col] == 'c')
                    {
                        totalCoals++;
                    }
                    else if (field[row, col] == 's')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            int currentRow = startRow;
            int currentCol = startCol;

            for (int i = 0; i < commands.Length; i++)
            {
                string currentCommand = commands[i];

                switch (currentCommand)
                {
                    case "up":
                        if (currentRow - 1 >= 0)
                        {
                            currentRow--;
                        }
                        break;
                    case "down":
                        if (currentRow + 1 < n)
                        {
                            currentRow++;
                        }
                        break;
                    case "left":
                        if (currentCol - 1 >= 0)
                        {
                            currentCol--;
                        }
                        break;
                    case "right":
                        if (currentCol + 1 < n)
                        {
                            currentCol++;
                        }
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

            Console.WriteLine($"{totalCoals} coals left. ({currentRow}, {currentCol})");
        }
    }
}
