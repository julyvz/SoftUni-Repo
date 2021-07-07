using System;
using System.Collections.Generic;
using System.Linq;

namespace _6FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBuyer> buyers = new List<IBuyer>();
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                IBuyer next;
                if (tokens.Length == 4) // Citizen
                {
                    next = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
                    buyers.Add(next);
                }
                else // Rebel
                {
                    next = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    buyers.Add(next);
                }
            }

            string command;
            int totalFood = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                IBuyer nextBuyer = buyers.FirstOrDefault(x => x.Name == command);
                if (nextBuyer is null)
                {
                    continue;
                }
                else
                {
                    int oldFood = nextBuyer.Food;
                    nextBuyer.BuyFood();
                    totalFood += nextBuyer.Food - oldFood;
                }
            }

            Console.WriteLine(totalFood);
        }
    }
}
