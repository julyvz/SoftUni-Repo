using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            string input = Console.ReadLine();

            while (input != "No more tires")
            {
                string[] tokens = input.Split();

                tires.Add(new Tire[4]
                    {
                    new Tire(int.Parse(tokens[0]), double.Parse(tokens[1])),
                    new Tire(int.Parse(tokens[2]), double.Parse(tokens[3])),
                    new Tire(int.Parse(tokens[4]), double.Parse(tokens[5])),
                    new Tire(int.Parse(tokens[6]), double.Parse(tokens[7]))
                    });

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Engines done")
            {
                string[] tokens = input.Split();
                engines.Add(new Engine(int.Parse(tokens[0]), double.Parse(tokens[1])));
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Show special")
            {
                string[] tokens = input.Split();
                cars.Add(new Car(tokens[0], tokens[1], int.Parse(tokens[2]), double.Parse(tokens[3]), double.Parse(tokens[4]), engines[int.Parse(tokens[5])], tires[int.Parse(tokens[6])]));
                input = Console.ReadLine();
            }

            foreach (var specialCar in cars.Where(x => x.Year >= 2017).Where(x => x.Engine.HorsePower > 330).Where(x => x.sumOfTirePressure >= 9 && x.sumOfTirePressure <= 10))
            {
                specialCar.Drive(20);
                Console.WriteLine($"Make: {specialCar.Make}");
                Console.WriteLine($"Model: {specialCar.Model}");
                Console.WriteLine($"Year: {specialCar.Year}");
                Console.WriteLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {specialCar.FuelQuantity}");
            }
        }
    }
}
