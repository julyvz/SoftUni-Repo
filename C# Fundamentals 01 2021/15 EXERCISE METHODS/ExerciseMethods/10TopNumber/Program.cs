using System;

namespace _10TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTopNumbers(n);
        }

        private static void PrintTopNumbers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int number = i;
                bool hasOdd = false;
                while (number > 0)
                {
                    int lastDigit = number % 10;
                    sum += lastDigit;
                    if (lastDigit % 2 != 0)
                    {
                        hasOdd = true;
                    }
                    number = number / 10;
                }
                if (sum % 8 == 0 && hasOdd)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
