using System;

namespace _8FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            double fact1 = Factorial(n1);
            double fact2 = Factorial(n2);
            double output = fact1 / fact2;
            Console.WriteLine($"{output:F2}");
        }

        private static double Factorial(int n)
        {
            double result = 1.0;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
