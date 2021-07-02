using System;
using System.Collections.Generic;
using System.Linq;

namespace _1Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> freshness = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            Dictionary<string, int> cookedDish = new Dictionary<string, int>()
            {
                { "Dipping sauce", 0 },
                { "Green salad", 0 },
                { "Chocolate cake", 0 },
                { "Lobster", 0 }
            };

            while (ingredients.Count > 0 && freshness.Count > 0)
            {
                int currIngredient = ingredients.Peek();

                if (currIngredient == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }

                int currFreshness = freshness.Pop();

                int currDish = currIngredient * currFreshness;

                switch (currDish)
                {
                    case 150:
                        cookedDish["Dipping sauce"]++;
                        break;

                    case 250:
                        cookedDish["Green salad"]++;
                        break;

                    case 300:
                        cookedDish["Chocolate cake"]++;
                        break;

                    case 400:
                        cookedDish["Lobster"]++;
                        break;

                    default:
                        ingredients.Enqueue(currIngredient + 5);
                        break;
                }
                ingredients.Dequeue();
            }

            if (cookedDish.All(x => x.Value > 0))
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }

            foreach (var item in cookedDish.Where(x => x.Value > 0).OrderBy(x => x.Key))
            {
                Console.WriteLine($" # {item.Key} --> {item.Value}");
            }
        }
    }
}
