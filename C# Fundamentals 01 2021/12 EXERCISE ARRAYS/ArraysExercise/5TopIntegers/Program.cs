using System;
using System.Linq;

namespace _5TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program to find all the top integers in an array. A top integer is an integer which is bigger than all the elements to its right. 

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                bool isTop = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        isTop = false;
                        break;
                    }
                }
                if (isTop)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
        }
    }
}
