using System;
using System.Collections.Generic;

namespace _2SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            int n = int.Parse(tokens[0]);
            int m = int.Parse(tokens[1]);

            HashSet<string> numbers1 = new HashSet<string>();
            HashSet<string> numbers2 = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                numbers1.Add(Console.ReadLine());
            }
            for (int i = 0; i < m; i++)
            {
                numbers2.Add(Console.ReadLine());
            }

            numbers1.IntersectWith(numbers2);

            Console.WriteLine(string.Join(' ', numbers1));
        }
    }
}
