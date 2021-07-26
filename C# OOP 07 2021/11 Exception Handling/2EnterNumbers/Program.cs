using System;

namespace _2EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[11];
            numbers[0] = 1;

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter 10 numbers such a 1 < a1 < … < a10 < 100");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write($"Please enter number {i}: ");
                        int nextNumber = ReadNumber(numbers[i - 1], 100 - 10 + i);
                        numbers[i] = nextNumber;
                    }
                    return;
                }
                catch (ArgumentOutOfRangeException ae)
                {
                    Console.WriteLine(ae.Message);
                    continue;
                }
            }
        }


        public static int ReadNumber(int start, int end)
        {
            int n = int.Parse(Console.ReadLine());
            if (n <= start || n >= end)
            {
                throw new ArgumentOutOfRangeException(nameof(n), $"Number should be between {start} and {end}");
            }

            return n;
        }
    }
}
