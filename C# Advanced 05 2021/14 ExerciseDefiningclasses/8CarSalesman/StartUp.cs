using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                int power = int.Parse(tokens[1]);
                var engine = new Engine(model, power);
                if (tokens.Length == 4)
                {
                    engine.Displacement = tokens[2];
                    engine.Efficiency = tokens[3];
                }
                else if (tokens.Length == 3)
                {
                    if (int.TryParse(tokens[2], out int displacement))
                    {
                        engine.Displacement = tokens[2];
                    }
                    else
                    {
                        engine.Efficiency = tokens[2];
                    }
                }
                engines.Add(engine);
            }

            n = int.Parse(Console.ReadLine());
            List<Car> garage = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                Engine engine = engines.Find(e => e.Model == tokens[1]);
                Car car = new Car(model, engine);
                if (tokens.Length == 4)
                {
                    car.Weight = tokens[2];
                    car.Color = tokens[3];
                }
                else if (tokens.Length == 3)
                {
                    if (int.TryParse(tokens[2], out int displacement))
                    {
                        car.Weight = tokens[2];
                    }
                    else
                    {
                        car.Color = tokens[2];
                    }
                }
                garage.Add(car);
            }

            foreach (var car in garage)
            {
                Console.WriteLine(car);
            }
        }
    }
}
