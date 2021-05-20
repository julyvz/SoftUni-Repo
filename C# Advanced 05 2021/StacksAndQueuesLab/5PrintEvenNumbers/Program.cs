using System;
using System.Collections.Generic;
using System.Linq;

namespace _5PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] nums = input.Split().Select(int.Parse).ToArray();
            Queue<int> myQueue = new Queue<int>(nums);
            Queue<int> output = new Queue<int>();

            while (myQueue.Count > 0)
            {
                if (myQueue.Peek() % 2 == 0)
                {
                    output.Enqueue(myQueue.Dequeue());
                }
                else
                {
                    myQueue.Dequeue();
                }
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
