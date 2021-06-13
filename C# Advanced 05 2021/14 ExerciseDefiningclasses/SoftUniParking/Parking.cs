using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private int capacity;
        private List<Car> cars;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new List<Car>();
        }

        public int Count
        {
            get { return this.cars.Count; }
        }


        public string AddCar(Car car)
        {
            string message = "";
            if (cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                message = "Car with that registration number, already exists!";
            }
            else if (cars.Count >= this.capacity)
            {
                message = "Parking is full!";
            }
            else
            {
                cars.Add(car);
                message = $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }

            return message;
        }

        public string RemoveCar(string registrationNumber)
        {
            string message = "";
            if (!cars.Any(x => x.RegistrationNumber == registrationNumber))
            {
                message = "Car with that registration number, doesn't exist!";
            }
            else
            {
                Car carToRemove = cars.Find(x => x.RegistrationNumber == registrationNumber);
                cars.Remove(carToRemove);
                message = $"Successfully removed {registrationNumber}";
            }
            return message;
        }

        public Car GetCar(string registrationNumber)
        {
            return cars.Find(x => x.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            for (int i = 0; i < registrationNumbers.Count; i++)
            {
                if (cars.Any(x => x.RegistrationNumber == registrationNumbers[i]))
                {
                    Car carToRemove = cars.Find(x => x.RegistrationNumber == registrationNumbers[i]);
                    cars.Remove(carToRemove);
                }
            }
        }
    }
}
