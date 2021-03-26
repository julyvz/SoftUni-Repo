using System;

namespace _2FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] numbers = input.Split(' ');
                long sum = 0;
                long a = long.Parse(numbers[0]);
                long b = long.Parse(numbers[1]);
                long c = Math.Max(a, b);
                c = Math.Abs(c);
                while (c > 0)
                {
                    sum += c % 10;
                    c = c / 10;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
