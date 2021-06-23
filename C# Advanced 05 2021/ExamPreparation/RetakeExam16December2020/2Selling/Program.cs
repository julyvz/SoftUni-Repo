using System;

namespace _2Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] bakery = new char[n, n];

            int row = 0;
            int col = 0;
            int money = 0;
            bool isOut = false;

            // initialize the matrix
            for (int i = 0; i < n; i++)
            {
                char[] temp = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    bakery[i, j] = temp[j];
                    if (bakery[i, j] == 'S')
                    {
                        row = i;
                        col = j;
                    }
                }
            }

            while (money < 50)
            {
                string direction = Console.ReadLine();
                bakery[row, col] = '-';
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
                    isOut = true;
                    break;
                }

                if (char.IsDigit(bakery[row, col]))
                {
                    money += int.Parse(bakery[row, col].ToString());
                }
                else if (bakery[row, col] == 'O')
                {
                    bakery[row, col] = '-';
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (bakery[i, j] == 'O')
                            {
                                row = i;
                                col = j;
                                break;
                            }
                        }
                    }
                }

                bakery[row, col] = 'S';
            }

            Console.WriteLine(isOut ? "Bad news, you are out of the bakery." : "Good news! You succeeded in collecting enough money!");
            Console.WriteLine($"Money: {money}");

            // print the matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(bakery[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
