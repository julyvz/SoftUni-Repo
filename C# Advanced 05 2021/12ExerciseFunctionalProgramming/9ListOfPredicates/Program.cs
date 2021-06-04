using System;
using System.Collections.Generic;
using System.Linq;

namespace _9ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, int[], bool> canDivide = (n, dividers) =>
            {
                bool itCan = true;
                foreach (var divider in dividers)
                {
                    if (n % divider != 0)
                    {
                        itCan = false;
                        break;
                    }
                }
                return itCan;
            };

            List<int> output = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (canDivide(i, dividers))
                {
                    output.Add(i);
                }
            }
            Console.WriteLine(string.Join(' ', output));
        }
    }
}
