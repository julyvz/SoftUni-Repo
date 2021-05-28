using System;
using System.Collections.Generic;

namespace _3ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> stores = new SortedDictionary<string, Dictionary<string, double>>();

            string input;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] tokens = input.Split(", ");
                string shop = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!stores.ContainsKey(shop))
                {
                    stores.Add(shop, new Dictionary<string, double>());
                }

                if (!stores[shop].ContainsKey(product))
                {
                    stores[shop].Add(product, price);
                }
            }

            foreach (var shop in stores)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
