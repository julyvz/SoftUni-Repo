using System;
using System.Linq;

namespace _5SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string snake = Console.ReadLine();

            int rows = sizes[0];
            int cols = sizes[1];

            char[,] matrix = new char[rows, cols];
            int idx = 0;
            int col = 0;
            string direction = "right";

            for (int row = 0; row < rows; row++)
            {
                while (true)
                {
                    matrix[row, col] = snake[idx++];
                    if (idx == snake.Length)
                    {
                        idx = 0;
                    }

                    if (direction == "right")
                    {
                        col++;
                        if (col == cols)
                        {
                            direction = "left";
                            col--;
                            break;
                        }
                    }
                    else
                    {
                        col--;
                        if (col < 0)
                        {
                            direction = "right";
                            col++;
                            break;
                        }
                    }
                }

            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
