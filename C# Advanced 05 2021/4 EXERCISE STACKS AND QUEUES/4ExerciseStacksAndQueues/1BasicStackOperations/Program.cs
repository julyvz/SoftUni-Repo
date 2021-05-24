using System;
using System.Collections.Generic;

namespace _1BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nsx = Console.ReadLine().Split();
            int n = int.Parse(nsx[0]);
            int s = int.Parse(nsx[1]);
            int x = int.Parse(nsx[2]);

            string[] numbers = Console.ReadLine().Split();
            Stack<int> theStack = new Stack<int>(n);

            foreach (var number in numbers)
            {
                theStack.Push(int.Parse(number));
            }

            for (int i = 0; i < s; i++)
            {
                theStack.Pop();
            }

            if (theStack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (theStack.Count == 0)
                {
                    Console.WriteLine("0");

                }
                else
                {
                    int[] sorted = theStack.ToArray();
                    Array.Sort(sorted);
                    Console.WriteLine(sorted[0]);
                }
            }
        }
    }
}
