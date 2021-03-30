using System;
using System.Linq;

namespace _3ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program which creates 2 arrays. You will be given an integer n. On the next n lines you get 2 integers. Form 2 arrays as shown below.

            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            int[] buffer = new int[2];
            short k = 0, l = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                buffer = input.Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    k = 0; l = 1;
                }
                else
                {
                    k = 1; l = 0;
                }
                arr1[i] = buffer[k];
                arr2[i] = buffer[l];
            }

            Console.WriteLine(String.Join(' ', arr1));
            Console.WriteLine(String.Join(' ', arr2));
        }
    }
}
