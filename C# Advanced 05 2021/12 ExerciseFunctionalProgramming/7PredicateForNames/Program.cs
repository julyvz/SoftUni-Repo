using System;
using System.Linq;

namespace _7PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Action<string[], int> printSelectedNames = (x, n) => Console.WriteLine(string.Join(Environment.NewLine, x.Where(y => y.Length <= n)));

            printSelectedNames(names, maxLength);
        }
    }
}
