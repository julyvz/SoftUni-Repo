using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionFor1km)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionFor1km;
            distanceTraveled = 0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double distanceTraveled { get; set; }

        public void Drive(double amountOfKm)
        {
            if (FuelAmount >= amountOfKm * FuelConsumptionPerKilometer)
            {
                FuelAmount -= amountOfKm * FuelConsumptionPerKilometer;
                distanceTraveled += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
