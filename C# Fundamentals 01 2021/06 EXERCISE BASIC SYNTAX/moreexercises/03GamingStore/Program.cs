using System;

namespace _03GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            double currentBalance = budget;
            double gamePrice;

            while (input != "Game Time")
            {
                switch (input)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        gamePrice = 0.0;
                        break;
                }
                if (gamePrice != 0)
                {
                    if (gamePrice > currentBalance )
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {input}");
                        currentBalance -= gamePrice;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${budget - currentBalance:F2}. Remaining: ${currentBalance:F2}");
        }
    }
}
