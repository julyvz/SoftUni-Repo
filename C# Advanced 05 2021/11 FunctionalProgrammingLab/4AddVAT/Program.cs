using System;
using System.Linq;

namespace _4AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> addVat = x => x * 1.2;

            double[] prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(addVat)
                .ToArray();
            foreach (var price in prices)
            {
                Console.WriteLine($"{price:F2}");
            }
        }
    }
}
