using System;

namespace _7MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds the longest sequence of equal elements in an array of integers. If several longest sequences exist, print the leftmost one.

            string[] arr = Console.ReadLine().Split();

            int maxCounter = 0;
            int maxIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    maxIndex = i;
                }
            }

            Console.WriteLine(String.Join(' ', arr, maxIndex, maxCounter));
        }
    }
}
