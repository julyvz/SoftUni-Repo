using System;

namespace _10MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            num = Math.Abs(num);

            Console.WriteLine(GetMultipleOfEvenAndOdds(num));
        }

        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                if ((n % 10) % 2 == 0)
                {
                    sum += n % 10;
                }
                n = n / 10;
            }
            return sum;
        }

        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                if ((n % 10) % 2 != 0)
                {
                    sum += n % 10;
                }
                n = n / 10;
            }
            return sum;
        }

        static int GetMultipleOfEvenAndOdds(int n)
        {
            return GetSumOfEvenDigits(n) * GetSumOfOddDigits(n);
        }


    }
}
