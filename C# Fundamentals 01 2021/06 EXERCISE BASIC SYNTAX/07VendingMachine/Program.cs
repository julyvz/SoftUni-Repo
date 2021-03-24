using System;

namespace _07VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double totalMoney = 0.0;

            while (input != "Start")
            {
                double nextCoin = double.Parse(input);
                if (nextCoin == 0.1 || nextCoin == 0.2 || nextCoin == 0.5 || nextCoin == 1 || nextCoin == 2)
                {
                    totalMoney += nextCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {nextCoin}");
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "End")
            {
                switch (input)
                {
                    case "Nuts":
                        if (totalMoney - 2 >= 0)
                        {
                            Console.WriteLine($"Purchased nuts");
                            totalMoney -= 2;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (totalMoney - 0.7 >= 0)
                        {
                            Console.WriteLine($"Purchased water");
                            totalMoney -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (totalMoney - 1.5 >= 0)
                        {
                            Console.WriteLine($"Purchased crisps");
                            totalMoney -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (totalMoney - 0.8 >= 0)
                        {
                            Console.WriteLine($"Purchased soda");
                            totalMoney -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (totalMoney - 1.0 >= 0)
                        {
                            Console.WriteLine($"Purchased coke");
                            totalMoney -= 1.0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {totalMoney:F2}");
        }
    }
}
