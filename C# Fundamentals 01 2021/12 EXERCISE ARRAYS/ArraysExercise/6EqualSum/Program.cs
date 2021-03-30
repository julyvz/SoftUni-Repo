using System;
using System.Linq;

namespace _6EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that determines if there exists an element in the array such that the sum of the elements on its left is equal to the sum of the elements on its right (there will never be more than 1 element like that). If there are no elements to the left / right, their sum is considered to be 0. Print the index that satisfies the required condition or "no" if there is no such index.

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }
                for (int k = i + 1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }                
                    Console.WriteLine("no");
        }
    }
}
