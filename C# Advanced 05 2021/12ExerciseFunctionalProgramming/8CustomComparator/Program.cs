using System;
using System.Linq;

namespace _8CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Comparison<int> whichIsBigger = (a, b) =>
            {
                if ((a % 2 == 0 && b % 2 == 0) || (a % 2 != 0 && b % 2 != 0))
                {
                    return a - b;
                }
                else if (a % 2 != 0 && b % 2 == 0)
                {
                    return 1;
                }
                else if (a % 2 == 0 && b % 2 != 0)
                {
                    return (-1);
                }
                return 0;
            };

            Array.Sort(numbers, whichIsBigger);
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
