using System;
using System.Linq;
using System.Collections.Generic;

namespace _3a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double[]> plants = new Dictionary<string, double[]>();
            Dictionary<string, List<double>> ratings = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plant = tokens[0];
                double rarity = double.Parse(tokens[1]);
                if (!plants.ContainsKey(plant))
                {
                    plants.Add(plant, new double[] { rarity, 0.0 });
                    ratings.Add(plant, new List<double>());
                }
                else
                {
                    plants[plant][0] = rarity;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Exhibition")
                {
                    break;
                }

                string[] tokens = input.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0].Trim();
                string[] arg = tokens[1].Trim().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string plant = arg[0].Trim();

                if (!plants.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                    continue;
                }

                switch (command)
                {
                    case "Rate":
                        double rating = double.Parse(arg[1].Trim());
                        ratings[plant].Add(rating);
                        break;

                    case "Update":
                        double rarity = double.Parse(arg[1].Trim());
                        plants[plant][0] = rarity;
                        break;

                    case "Reset":
                        ratings[plant].Clear();
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            foreach (var plant in plants)
            {
                if (ratings[plant.Key].Count > 0)
                {
                    plant.Value[1] = ratings[plant.Key].Average();
                }
                else
                {
                    plant.Value[1] = 0.0;
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plants.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]))
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value[0]}; Rating: {plant.Value[1]:F2}");
            }
        }
    }
}
