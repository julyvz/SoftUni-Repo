using System;
using System.Linq;

namespace _8MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program, which prints all unique pairs in an array of integers whose sum is equal to a given number.

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int target = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]}");
                        break;
                    }
                }
            }

        }
    }
}
