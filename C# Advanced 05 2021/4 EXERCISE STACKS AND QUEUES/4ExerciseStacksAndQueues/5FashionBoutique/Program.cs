using System;
using System.Collections.Generic;
using System.Linq;

namespace _5FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> box = new Stack<int>(clothes);

            int racksNeeded = box.Sum() == 0 ? 0 : 1;
            int currentCapacity = capacity;

            while (box.Count > 0)
            {
                if (box.Peek() == 0)
                {
                    box.Pop();
                }
                else
                {
                    if (currentCapacity - box.Peek() >= 0)
                    {
                        currentCapacity -= box.Pop();
                    }
                    else
                    {
                        racksNeeded++;
                        currentCapacity = capacity;
                    }
                }
            }

            Console.WriteLine(racksNeeded);
        }
    }
}
