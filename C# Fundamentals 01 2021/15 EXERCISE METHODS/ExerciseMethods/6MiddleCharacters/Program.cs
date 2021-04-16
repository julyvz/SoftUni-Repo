using System;

namespace _6MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddle(input);
        }

        private static void PrintMiddle(string input)
        {
            int n = input.Length;
            if (n % 2 == 0)
            {
                Console.WriteLine(input[n / 2 - 1] + "" + input[n / 2]);
            }
            else
            {
                Console.WriteLine(input[n / 2]);
            }
        }
    }
}
