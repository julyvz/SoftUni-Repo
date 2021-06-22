using System;

namespace _2Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] field = new char[n, n];

            int row = 0;
            int col = 0;
            int pollinateFlowers = 0;

            // initialize the matrix
            for (int i = 0; i < n; i++)
            {
                char[] temp = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    field[i, j] = temp[j];
                    if (field[i, j] == 'B')
                    {
                        row = i;
                        col = j;
                    }
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                field[row, col] = '.';
                switch (command)
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
                    Console.WriteLine("The bee got lost!");
                    break;
                }

                if (field[row, col] == 'f')
                {
                    pollinateFlowers++;
                }
                else if (field[row, col] == 'O')
                {
                    field[row, col] = '.';
                    switch (command)
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
                    if (field[row, col] == 'f')
                    {
                        pollinateFlowers++;
                    }
                }
                field[row, col] = 'B';
            }

            if (pollinateFlowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinateFlowers} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinateFlowers} flowers!");
            }

            //print
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
