using System;

namespace _2Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int row = 0;
            int col = 0;
            int food = 0;
            bool goesOutside = false;

            char[,] field = new char[n, n];

            // initialize the field
            for (int i = 0; i < n; i++)
            {
                char[] temp = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    field[i, j] = temp[j];
                    if (field[i, j] == 'S')
                    {
                        row = i;
                        col = j;
                    }
                }
            }

            while (food < 10)
            {
                string direction = Console.ReadLine();
                field[row, col] = '.';
                switch (direction)
                {
                    case "up":
                        row--;
                        break;
                    case "down":
                        row++;
                        break;
                    case "left":
                        col--;
                        break;
                    case "right":
                        col++;
                        break;
                }

                if (row < 0 || row >= n || col < 0 || col >= n)
                {
                    goesOutside = true;
                    break;
                }

                if (field[row, col] == '*')
                {
                    food++;
                }
                else if (field[row, col] == 'B')
                {
                    field[row, col] = '.';
                    //find other 'B'
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (field[i, j] == 'B')
                            {
                                row = i;
                                col = j;
                            }
                        }
                    }
                }

                field[row, col] = 'S';
            }

            if (goesOutside)
            {
                Console.WriteLine("Game over!");
            }
            else
            {
                Console.WriteLine("You won! You fed the snake.");
            }

            Console.WriteLine($"Food eaten: {food}");

            // print field
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
