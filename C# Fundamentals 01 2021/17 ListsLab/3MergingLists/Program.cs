using System;
using System.Collections.Generic;
using System.Linq;

namespace _3MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> numbers2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            if (numbers1.Count >= numbers2.Count)
            {
                for (int i = 0; i < numbers2.Count; i++)
                {
                    numbers1.Insert(2 * i + 1, numbers2[i]);
                }
                Console.WriteLine(string.Join(' ', numbers1));
            }
            else
            {
                for (int i = 0; i < numbers1.Count; i++)
                {
                    numbers2.Insert(2 * i, numbers1[i]);
                }
                Console.WriteLine(string.Join(' ', numbers2));
            }
        }
    }
}
