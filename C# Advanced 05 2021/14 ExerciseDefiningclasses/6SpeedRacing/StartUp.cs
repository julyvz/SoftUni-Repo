using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> garage = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string model = tokens[0];
                double fuelAmount = double.Parse(tokens[1]);
                double fuelConsumptionFor1km = double.Parse(tokens[2]);
                Car current = new Car(model, fuelAmount, fuelConsumptionFor1km);
                garage.Add(current);
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string carModel = tokens[1];
                double amountOfKm = double.Parse(tokens[2]);
                garage.Where(x => x.Model == carModel).FirstOrDefault().Drive(amountOfKm);
            }

            foreach (var car in garage)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.distanceTraveled}");
            }
        }
    }
}
