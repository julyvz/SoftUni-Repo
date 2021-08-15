using CarRacing.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Cars
{
    public abstract class Car : ICar
    {
        private string vin;
        private int horsePower;
        private double fuelAvailable;
        private double fuelConsumtpionPerRace;

        protected Car(string make, string model, string vIN, int horsePower, double fuelAvailable, double fuelConsumptionPerRace)
        {
            if (string.IsNullOrWhiteSpace(make))
            {
                throw new ArgumentException("Car make cannot be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("Car model cannot be null or empty.");
            }

            Make = make;
            Model = model;
            VIN = vIN;
            HorsePower = horsePower;
            FuelAvailable = fuelAvailable;
            FuelConsumptionPerRace = fuelConsumptionPerRace;
        }

        public string Make { get; }

        public string Model { get; }

        public string VIN
        { 
            get => vin;
            set
            {
                if (value.Length != 17)
                {
                    throw new ArgumentException("Car VIN must be exactly 17 characters long.");
                }

                vin = value;
            }
        }

        public int HorsePower
        {
            get => horsePower;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Horse power cannot be below 0.");
                }

                horsePower = value;
            }
        }

        public double FuelAvailable
        {
            get => fuelAvailable;
            set
            {
                if (value < 0)
                {
                    fuelAvailable = 0;
                }

                fuelAvailable = value;
            }
        }

        public double FuelConsumptionPerRace
        {
            get => fuelConsumtpionPerRace;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel consumption cannot be below 0.");
                }

                fuelConsumtpionPerRace = value;
            }
        }

        public virtual void Drive() // PP virtual
        {
            FuelAvailable -= FuelConsumptionPerRace;
        }
    }
}
