using System;
using System.Linq;

namespace _6JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jagged = new double[n][];

            for (int i = 0; i < n; i++)
            {
                double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
                jagged[i] = arr;
            }

            for (int row = 0; row < n - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int i = 0; i < jagged[row].Length; i++)
                    {
                        jagged[row][i] *= 2;
                        jagged[row + 1][i] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < jagged[row].Length; i++)
                    {
                        jagged[row][i] /= 2;
                    }
                    for (int i = 0; i < jagged[row + 1].Length; i++)
                    {
                        jagged[row + 1][i] /= 2;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split();
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row < 0 || row >= n || col < 0 || col >= jagged[row].Length)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (tokens[0] == "Add")
                {
                    jagged[row][col] += value;
                }
                else // Subtract
                {
                    jagged[row][col] -= value;
                }

                command = Console.ReadLine();
            }

            foreach (var row in jagged)
            {
                Console.WriteLine(string.Join(' ', row));
            }
        }
    }
}
