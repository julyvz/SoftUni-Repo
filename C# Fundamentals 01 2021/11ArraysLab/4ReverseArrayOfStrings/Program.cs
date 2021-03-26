using System;
using System.Linq;

namespace _4ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length / 2; i++)
            {
                var oldItem = input[i];
                input[i] = input[input.Length - 1 - i];
                input[input.Length - 1 - i] = oldItem;
            }
            Console.WriteLine(String.Join(' ', input));
        }
    }
}
