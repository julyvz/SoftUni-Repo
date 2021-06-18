using System;
using System.Collections.Generic;
using System.Linq;

namespace _1WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> scarfs = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            List<int> sets = new List<int>();

            while (hats.Count != 0 && scarfs.Count != 0)
            {
                int hat = hats.Peek();
                int scarf = scarfs.Peek();
                if (hat > scarf)
                {
                    sets.Add(hats.Pop() + scarfs.Dequeue());
                }
                else if (hat == scarf)
                {
                    scarfs.Dequeue();
                    hats.Push(hats.Pop() + 1);
                }
                else
                {
                    hats.Pop();
                }
            }

            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine(string.Join(' ', sets));
        }
    }
}
