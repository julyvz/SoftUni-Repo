using System;
using System.Collections.Generic;

namespace _4EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> set1 = new HashSet<string>();
            HashSet<string> set2 = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string num = Console.ReadLine();

                if (set2.Contains(num))
                {
                    set2.Remove(num);
                }
                else
                {
                    if (set1.Contains(num))
                    {
                        set2.Add(num);
                    }
                    else
                    {
                        set1.Add(num);
                    }
                }
            }

            Console.WriteLine(string.Join(' ', set2));
        }
    }
}
