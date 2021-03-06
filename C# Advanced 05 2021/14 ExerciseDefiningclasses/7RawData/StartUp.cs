using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> fleet = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                fleet.Add(new Car(tokens[0], int.Parse(tokens[1]), int.Parse(tokens[2]), int.Parse(tokens[3]), tokens[4], double.Parse(tokens[5]), int.Parse(tokens[6]), double.Parse(tokens[7]), int.Parse(tokens[8]), double.Parse(tokens[9]), int.Parse(tokens[10]), double.Parse(tokens[11]), int.Parse(tokens[12])));
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (var car in fleet.Where(x => x.Cargo.CargoType == "fragile" && x.Tires.Any(y => y.TirePressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                foreach (var car in fleet.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
