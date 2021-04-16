using System;

namespace _1SmallestfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method to print the smallest of three integer numbers.

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(ReturnSmallestNumber(n1, n2, n3));
        }

        static int ReturnSmallestNumber(int n1, int n2, int n3)
        {
            int smallest = Math.Min(n1, Math.Min(n2, n3));
            return smallest;
        }
    }
}
