using System;
using System.Linq;
using System.Collections.Generic;

namespace _3NeedForSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int[]> cars = new Dictionary<string, int[]>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('|');
                cars.Add(input[0], new[] { int.Parse(input[1]), int.Parse(input[2]) });
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Stop")
                {
                    break;
                }

                string[] tokens = command.Split(" : ");
                string car = tokens[1];

                switch (tokens[0])
                {
                    case "Drive":
                        int distance = int.Parse(tokens[2]);
                        int fuel = int.Parse(tokens[3]);
                        if (fuel > cars[car][1])
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            cars[car][0] += distance;
                            cars[car][1] -= fuel;
                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                            if (cars[car][0] >= 100000)
                            {
                                Console.WriteLine($"Time to sell the {car}!");
                                cars.Remove(car);
                            }
                        }
                        break;

                    case "Refuel":
                        fuel = int.Parse(tokens[2]);
                        if (cars[car][1] + fuel > 75)
                        {
                            fuel = 75 - cars[car][1];
                        }
                        cars[car][1] += fuel;
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                        break;

                    case "Revert":
                        distance = int.Parse(tokens[2]);
                        cars[car][0] -= distance;
                        if (cars[car][0] < 10000)
                        {
                            cars[car][0] = 10000;
                        }
                        else
                        {
                            Console.WriteLine($"{car} mileage decreased by {distance} kilometers");
                        }
                        break;
                }
            }
            foreach (var car in cars.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}
