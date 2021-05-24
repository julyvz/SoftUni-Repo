using System;
using System.Collections.Generic;
using System.Linq;

namespace _12CupsAndBottles
{
    class Program // Dava 88/100 v Judge
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queueOfCups = new Queue<int>(cups);
            Stack<int> stackOfBottles = new Stack<int>(bottles);

            int wastedWater = 0;
            int currentCup = 0;

            while (queueOfCups.Count > 0 && stackOfBottles.Count > 0)
            {
                if (currentCup <= 0)
                {
                    currentCup = queueOfCups.Dequeue();
                }
                if (stackOfBottles.Peek() > currentCup)
                {
                    wastedWater += stackOfBottles.Peek() - currentCup;
                    currentCup -= stackOfBottles.Pop();
                }
                else // <=
                {
                    currentCup -= stackOfBottles.Pop();
                }
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
