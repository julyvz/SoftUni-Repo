using System;
using System.Linq;

namespace _5LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] potential = new int[arr.Length];
            int[] currentArr = new int[arr.Length];
            int[] bestArr = new int[arr.Length];
            int bestStartIndex = 0;
            int bestLength = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int counterPotential = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        counterPotential++;
                    }
                }
                potential[i] = counterPotential;
            }

            Console.WriteLine(String.Join(' ', potential));

            for (int i = 0; i < arr.Length; i++)
            {

                int bestPotential = 0;
                int bestPotentialIndex = 0;
                int length = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i] && potential[j] > bestPotential)
                    {
                        bestPotential = potential[j];
                        bestPotentialIndex = j;
                        length++;
                    }
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestStartIndex = i;
                }

            }
            Console.WriteLine($"{bestStartIndex} {bestLength}");
        }
    }
}
