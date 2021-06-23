using System;
using System.Collections.Generic;
using System.Linq;

namespace _1Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> ingredients = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int bread = 0;
            int cake = 0;
            int fruitPie = 0;
            int pastry = 0;

            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                int currLiquid = liquids.Dequeue();
                int currIngredient = ingredients.Pop();
                int sum = currLiquid + currIngredient;
                switch (sum)
                {
                    case 25:
                        bread++;
                        break;

                    case 50:
                        cake++;
                        break;

                    case 75:
                        pastry++;
                        break;

                    case 100:
                        fruitPie++;
                        break;

                    default:
                        ingredients.Push(currIngredient + 3);
                        break;
                }
            }

            if (bread >= 1 && cake >= 1 && pastry >= 1 && fruitPie >= 1)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            Console.WriteLine(liquids.Count == 0 ? "Liquids left: none" : "Liquids left: " + $"{string.Join(", ", liquids)}");
            Console.WriteLine(ingredients.Count == 0 ? "Ingredients left: none" : "Ingredients left: " + $"{string.Join(", ", ingredients)}");
            Console.WriteLine($"Bread: {bread}");
            Console.WriteLine($"Cake: {cake}");
            Console.WriteLine($"Fruit Pie: {fruitPie}");
            Console.WriteLine($"Pastry: {pastry}");
        }
    }
}
