using System;
using System.Collections.Generic;
using System.Linq;

namespace _4ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>(n);

            for (int i = 0; i < n; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
            int order = 1;
            foreach (var product in products)
            {
            Console.WriteLine($"{order++}.{product}");                
            }
        }
    }
}
