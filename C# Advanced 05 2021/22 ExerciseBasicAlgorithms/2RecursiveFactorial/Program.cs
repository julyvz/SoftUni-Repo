using System;

namespace _2RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long factorial = 1;

            if (n != 0)
            {
                factorial = Factorial(n);
            }

            Console.WriteLine(factorial);
        }

        private static long Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}
