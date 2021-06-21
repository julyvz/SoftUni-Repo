using System;
using System.Collections.Generic;
using System.Linq;

namespace _1Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> secondBox = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            List<int> myCollection = new List<int>();

            while (firstBox.Count > 0 && secondBox.Count > 0)
            {
                int currentFromFirst = firstBox.Peek();
                int currentFromSecond = secondBox.Pop();
                int sum = currentFromFirst + currentFromSecond;
                if (sum % 2 == 0)
                {
                    myCollection.Add(sum);
                    firstBox.Dequeue();
                }
                else
                {
                    firstBox.Enqueue(currentFromSecond);
                }
            }

            if (firstBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            int sumOfmyCollection = myCollection.Sum();
            if (sumOfmyCollection >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sumOfmyCollection}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sumOfmyCollection}");
            }
        }
    }
}
