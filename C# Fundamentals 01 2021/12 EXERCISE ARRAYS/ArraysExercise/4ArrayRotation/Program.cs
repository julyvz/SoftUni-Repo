using System;

namespace _4ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that receives an array and number of rotations you have to perform (first element goes at the end) Print the resulting array.

            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string[] arr = input.Split();
            int l = arr.Length;
            string[] arrRotated = new string[l];

            for (int i = 0; i < l; i++)
            {
                if (i + (n % l) >= l)
                {
                    arrRotated[i] = arr[i + (n % l) - l];

                }
                else
                {
                    arrRotated[i] = arr[i + (n % l)];
                }
            }

            Console.WriteLine(String.Join(' ', arrRotated));
        }
    }
}
