using System;
using System.Collections.Generic;
using System.Linq;

namespace _6ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            numbers = numbers.Reverse().Where(x => x % n != 0).ToArray();
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
