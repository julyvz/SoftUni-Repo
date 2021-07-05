using System;

namespace _4PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaTokens = Console.ReadLine().Split();
                Pizza myPizza = new Pizza(pizzaTokens[1]);

                string input;
                while ((input = Console.ReadLine()) != "END")
                {
                    string[] tokens = input.Split();

                    string ingredient = tokens[0];

                    switch (ingredient)
                    {
                        case "Dough":
                            string flourType = tokens[1].ToLower();
                            string bakingTechnique = tokens[2].ToLower();
                            int weight = int.Parse(tokens[3]);
                            Dough dough = new Dough(flourType, bakingTechnique, weight);

                            myPizza.Dough = dough;
                            break;

                        case "Topping":
                            string type = tokens[1];
                            weight = int.Parse(tokens[2]);
                            Topping topping = new Topping(type, weight);

                            myPizza.AddTopping(topping);

                            break;
                    }
                }

                Console.WriteLine($"{myPizza.Name} - {myPizza.TotalCalories:F2} Calories.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}

