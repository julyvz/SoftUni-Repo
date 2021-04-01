using System;

namespace _5Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PrintReceit(product, quantity);
        }

        static void PrintReceit(string product, int quantity)
        {
            double productPrice = 0.0;
            switch (product)
            {
                case "coffee":
                    productPrice = 1.50;
                    break;
                case "water":
                    productPrice = 1.00;
                    break;
                case "coke":
                    productPrice = 1.40;
                    break;
                case "snacks":
                    productPrice = 2.00;
                    break;
            }
            Console.WriteLine($"{quantity * productPrice:F2}");
        }
    }
}
