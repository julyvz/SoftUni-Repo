using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, int speed, int power, int cargoWeight, string cargoType, double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            Model = model;
            Engine = new Engine { EngineSpeed = speed, EnginePower = power };
            Cargo = new Cargo { CargoWeight = cargoWeight, CargoType = cargoType };
            Tires = new Tire[4];
            Tires[0] = new Tire { TirePressure = tire1Pressure, TireAge = tire1Age };
            Tires[1] = new Tire { TirePressure = tire2Pressure, TireAge = tire2Age };
            Tires[2] = new Tire { TirePressure = tire3Pressure, TireAge = tire3Age };
            Tires[3] = new Tire { TirePressure = tire4Pressure, TireAge = tire4Age };
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public  Tire[] Tires { get; set; }
    }
}
