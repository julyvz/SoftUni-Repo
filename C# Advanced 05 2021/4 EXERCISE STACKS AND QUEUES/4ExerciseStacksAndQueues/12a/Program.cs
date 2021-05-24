using System;
using System.Collections.Generic;
using System.Linq;

namespace _12a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queueOfCups = new Queue<int>(cups);
            Stack<int> stackOfBottles = new Stack<int>(bottles);

            int wastedWater = 0;

            while (queueOfCups.Count > 0 && stackOfBottles.Count > 0)
            {
                int currentCup = queueOfCups.Dequeue();
                while (currentCup > 0)
                {
                    currentCup -= stackOfBottles.Pop();
                }
                wastedWater -= currentCup;
            }

            if (queueOfCups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(' ', stackOfBottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(' ', queueOfCups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
