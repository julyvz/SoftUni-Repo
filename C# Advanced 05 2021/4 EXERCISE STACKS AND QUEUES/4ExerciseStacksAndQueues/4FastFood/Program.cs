using System;
using System.Collections.Generic;
using System.Linq;

namespace _4FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int availableFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(orders.Max());

            Queue<int> currentOrders = new Queue<int>(orders);
            while (availableFood > 0 && currentOrders.Count != 0)
            {
                if (availableFood - currentOrders.Peek() < 0)
                {
                    break;
                }
                availableFood -= currentOrders.Dequeue();
            }

            if (currentOrders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine("Orders left: " + string.Join(' ', currentOrders));
            }
        }
    }
}
