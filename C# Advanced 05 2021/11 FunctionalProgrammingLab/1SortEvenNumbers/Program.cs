using System;
using System.Linq;

namespace _1SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse)
                .Where(n => n % 2 == 0).OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
