using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            Car car = new Car(double.Parse(tokens[1]), double.Parse(tokens[2]), double.Parse(tokens[3]));
            tokens = Console.ReadLine().Split();
            Truck truck = new Truck(double.Parse(tokens[1]), double.Parse(tokens[2]), double.Parse(tokens[3]));
            tokens = Console.ReadLine().Split();
            Bus bus = new Bus(double.Parse(tokens[1]), double.Parse(tokens[2]), double.Parse(tokens[3]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                 tokens = Console.ReadLine().Split();
                if (tokens[0] == "Drive")
                {
                    if (tokens[1] == "Car")
                    {
                        Console.WriteLine(car.Drive(double.Parse(tokens[2])));
                    }
                    else if(tokens[1] == "Truck")
                    {
                        Console.WriteLine(truck.Drive(double.Parse(tokens[2])));
                    }
                    else
                    {
                        Console.WriteLine(bus.Drive(double.Parse(tokens[2])));
                    }
                }
                else if (tokens[0] == "Refuel")
                {                   
                    if (tokens[1] == "Car")
                    {
                        car.Refuel(double.Parse(tokens[2]));
                    }
                    else if (tokens[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(tokens[2]));
                    }
                    else
                    {
                        bus.Refuel(double.Parse(tokens[2]));
                    }
                }
                else // DriveEmpty
                {
                    Console.WriteLine(bus.DriveEmpty(double.Parse(tokens[2])));
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}
