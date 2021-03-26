using System;
using System.Linq;

namespace _3RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double[] numbers = input.
                Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            int[] intNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                intNumbers[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{Convert.ToDecimal(numbers[i])} => {intNumbers[i]}");
            }
        }
    }
}
