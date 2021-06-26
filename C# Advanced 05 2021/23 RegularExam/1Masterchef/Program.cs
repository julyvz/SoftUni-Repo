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

            int dippingSauce = 0;
            int greenSalad = 0;
            int chocolateCake = 0;
            int lobster = 0;

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
                        dippingSauce++;
                        ingredients.Dequeue();
                        break;

                    case 250:
                        greenSalad++;
                        ingredients.Dequeue();
                        break;

                    case 300:
                        chocolateCake++;
                        ingredients.Dequeue();
                        break;

                    case 400:
                        lobster++;
                        ingredients.Dequeue();
                        break;

                    default:
                        ingredients.Enqueue(ingredients.Dequeue() + 5);
                        break;
                }
            }

            if (dippingSauce > 0 && greenSalad > 0 && chocolateCake > 0 && lobster > 0)
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

            if (chocolateCake > 0)
            {
                Console.WriteLine($" # Chocolate cake --> {chocolateCake}");
            }
            if (dippingSauce > 0)
            {
                Console.WriteLine($" # Dipping sauce --> {dippingSauce}");
            }
            if (greenSalad > 0)
            {
                Console.WriteLine($" # Green salad --> {greenSalad}");
            }
            if (lobster > 0)
            {
                Console.WriteLine($" # Lobster --> {lobster}");
            }
        }
    }
}
