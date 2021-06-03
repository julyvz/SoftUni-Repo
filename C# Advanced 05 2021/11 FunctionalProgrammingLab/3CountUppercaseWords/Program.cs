using System;
using System.Linq;

namespace _3CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> startsUpper = x => char.IsUpper(x[0]);
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(startsUpper).ToArray();
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
