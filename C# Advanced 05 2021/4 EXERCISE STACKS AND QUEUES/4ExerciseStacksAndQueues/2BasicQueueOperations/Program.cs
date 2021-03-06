using System;
using System.Collections.Generic;

namespace _2BasicQueueOperations
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
            Queue<int> theQueue = new Queue<int>(n);

            foreach (var number in numbers)
            {
                theQueue.Enqueue(int.Parse(number));
            }

            for (int i = 0; i < s; i++)
            {
                theQueue.Dequeue();
            }

            if (theQueue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (theQueue.Count == 0)
                {
                    Console.WriteLine("0");

                }
                else
                {
                    int[] sorted = theQueue.ToArray();
                    Array.Sort(sorted);
                    Console.WriteLine(sorted[0]);
                }
            }
        }
    }
}
