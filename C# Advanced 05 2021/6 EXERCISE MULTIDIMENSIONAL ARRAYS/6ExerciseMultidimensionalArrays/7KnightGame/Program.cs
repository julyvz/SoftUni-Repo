using System;

namespace _7KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] desk = new char[n, n];

            int[,] threats = new int[n, n];

            int knightsRemoved = 0;

            // Populate matrix
            for (int i = 0; i < n; i++)
            {
                char[] arr = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    desk[i, j] = arr[j];
                }
            }

            int maxThreat = 0;
            int maxRow = -1;
            int maxCol = -1;

            do
            {
                maxThreat = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (desk[i, j] == '0')
                        {
                            continue;
                        }
                        else
                        {
                            int currentThreat = CalculateConflicts(n, desk, i, j);
                            threats[i, j] = currentThreat;
                            if (currentThreat > maxThreat)
                            {
                                maxThreat = currentThreat;
                                maxRow = i;
                                maxCol = j;
                            }
                        }
                    }
                }
                if (maxThreat > 0)
                {

                    desk[maxRow, maxCol] = '0';
                    threats[maxRow, maxCol] = 0;
                    knightsRemoved++;
                }
            } while (maxThreat > 0);

            Console.WriteLine(knightsRemoved);
        }

        private static int CalculateConflicts(int n, char[,] desk, int i, int j)
        {
            int conflicts = 0;
            if (i - 2 >= 0)
            {
                if (j - 1 >= 0 && desk[i - 2, j - 1] == 'K')
                {
                    conflicts++;
                }
                if (j + 1 < n && desk[i - 2, j + 1] == 'K')
                {
                    conflicts++;
                }
            }
            if (i - 1 >= 0)
            {
                if (j - 2 >= 0 && desk[i - 1, j - 2] == 'K')
                {
                    conflicts++;
                }
                if (j + 2 < n && desk[i - 1, j + 2] == 'K')
                {
                    conflicts++;
                }
            }
            if (i + 1 < n)
            {
                if (j - 2 >= 0 && desk[i + 1, j - 2] == 'K')
                {
                    conflicts++;
                }
                if (j + 2 < n && desk[i + 1, j + 2] == 'K')
                {
                    conflicts++;
                }
            }
            if (i + 2 < n)
            {
                if (j - 1 >= 0 && desk[i + 2, j - 1] == 'K')
                {
                    conflicts++;
                }
                if (j + 1 < n && desk[i + 2, j + 1] == 'K')
                {
                    conflicts++;
                }
            }
            return conflicts;
        }
    }
}
