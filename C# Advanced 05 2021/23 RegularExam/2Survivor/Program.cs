using System;

namespace _2Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countOfCollected = 0;
            int countOfOpponentsTokens = 0;

            char[][] beach = new char[n][];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                beach[i] = new char[input.Length];
                for (int j = 0; j < input.Length; j++)
                {
                    beach[i][j] = char.Parse(input[j]);
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "Gong")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);

                if (row < 0 || row >= n || col < 0 || col >= beach[row].Length)
                {
                    continue;
                }

                if (tokens[0] == "Find")
                {
                    if (beach[row][col] == 'T')
                    {
                        countOfCollected++;
                        beach[row][col] = '-';
                    }
                }
                else // Opponent
                {
                    string direction = tokens[3];
                    if (beach[row][col] == 'T')
                    {
                        countOfOpponentsTokens++;
                        beach[row][col] = '-';
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        switch (direction)
                        {
                            case "up":
                                row = row == 0 ? 0 : row - 1;
                                break;

                            case "down":
                                row = row == n - 1 ? n - 1 : row + 1;
                                break;

                            case "left":
                                col = col == 0 ? 0 : col - 1;
                                break;

                            case "right":
                                col = col == beach[row].Length - 1 ? beach[row].Length - 1 : col + 1;
                                break;
                        }

                        if (beach[row][col] == 'T')
                        {
                            countOfOpponentsTokens++;
                            beach[row][col] = '-';
                        }
                    }
                }
            }


            //print
            foreach (char[] row in beach)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            Console.WriteLine($"Collected tokens: {countOfCollected}");
            Console.WriteLine($"Opponent's tokens: {countOfOpponentsTokens}");
        }
    }
}
