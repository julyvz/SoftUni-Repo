using System;
using System.Collections.Generic;

namespace _3ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] persons = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] products = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            List<Person> customers = new List<Person>();
            List<Product> assortiment = new List<Product>();

            foreach (var person in persons)
            {
                try
                {
                    string[] tokens = person.Split('=', StringSplitOptions.RemoveEmptyEntries);
                    string name = tokens[0];
                    int money = int.Parse(tokens[1]);

                    Person nextCustomer = new Person(name, money);
                    customers.Add(nextCustomer);
                }

                catch (Exception ae)
                {
                    Console.WriteLine(ae.Message);
                    return;
                }
            }

            foreach (var product in products)
            {
                try
                {
                    string[] tokens = product.Split('=', StringSplitOptions.RemoveEmptyEntries);
                    string name = tokens[0];
                    int cost = int.Parse(tokens[1]);

                    Product nextProduct = new Product(name, cost);
                    assortiment.Add(nextProduct);
                }

                catch (Exception ae)
                {
                    Console.WriteLine(ae.Message);
                    return;
                }
            }


            string command;
            while ((command = Console.ReadLine())!= "END")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string customerName = tokens[0];
                string productName = tokens[1];

                Person currCustomer = customers.Find(x => x.Name == customerName);
                Product currProduct = assortiment.Find(x => x.Name == productName);

                if (currCustomer.Money >= currProduct.Cost)
                {
                    currCustomer.Money -= currProduct.Cost;
                    currCustomer.AddToBag(currProduct.Name);
                    Console.WriteLine($"{currCustomer.Name} bought {currProduct.Name}");
                }
                else
                {
                    Console.WriteLine($"{currCustomer.Name} can't afford {currProduct.Name}");
                }
            }

            foreach (var customer in customers)
            {
                Console.Write($"{customer.Name} - ");
                Console.WriteLine(customer.BagOfProducts.Count == 0 ? "Nothing bought" : $"{string.Join(", ", customer.BagOfProducts)}");
            }
        }
    }
}
