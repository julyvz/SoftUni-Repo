using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Parking
{
    public class Parking
    {
        private List<Car> cars;

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            cars = new List<Car>();
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count => cars.Count;

        public void Add(Car car)
        {
            if (cars.Count < Capacity)
            {
                cars.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Car toBeRemoved = cars.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
            if (toBeRemoved != null)
            {
                cars.Remove(toBeRemoved);
                return true;
            }
            return false;
        }

        public Car GetLatestCar()
        {
            if (cars.Count == 0)
            {
                return null;
            }
            else
            {
                Car latest = cars.OrderByDescending(x => x.Year).First();
                return latest;
            }
        }

        public Car GetCar(string manufacturer, string model)
        {
            Car car = cars.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
            return car;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            foreach (var car in cars)
            {
                sb.AppendLine($"{car}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
