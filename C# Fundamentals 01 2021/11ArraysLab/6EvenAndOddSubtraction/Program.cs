using System;
using System.Linq;

namespace _6EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }

            Console.WriteLine(evenSum - oddSum);
        }
    }
}
