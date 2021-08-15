using CarRacing.Core.Contracts;
using CarRacing.Models.Cars;
using CarRacing.Models.Cars.Contracts;
using CarRacing.Models.Maps;
using CarRacing.Models.Racers;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories;
using CarRacing.Utilities.Messages;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Core
{
    public class Controller : IController
    {
        private CarRepository cars;
        private RacerRepository racers;
        private Map map;

        public Controller()
        {
            cars = new CarRepository();
            racers = new RacerRepository();
            map = new Map();
        }

        public string AddCar(string type, string make, string model, string VIN, int horsePower)
        {
            ICar car;
            
            switch (type)
            {
                case "SuperCar":
                    car = new SuperCar(make, model, VIN, horsePower);
                    break;

                case "TunedCar":
                    car = new TunedCar(make, model, VIN, horsePower);
                    break;

                default:
                    throw new ArgumentException("Invalid car type!");
            }

            cars.Add(car);

            return string.Format(OutputMessages.SuccessfullyAddedCar, car.Make, car.Model, car.VIN);
        }

        public string AddRacer(string type, string username, string carVIN)
        {
            IRacer racer;

            ICar car = cars.FindBy(carVIN);

            if (car is null)
            {
                throw new ArgumentException("Car cannot be found!");
            }

            switch (type)
            {
                case "ProfessionalRacer":
                    racer = new ProfessionalRacer(username, car);
                    break;

                case "StreetRacer":
                    racer = new StreetRacer(username, car);
                    break;

                default:
                    throw new ArgumentException("Invalid racer type!");
            }

            racers.Add(racer);

            return string.Format(OutputMessages.SuccessfullyAddedRacer, username);
        }

        public string BeginRace(string racerOneUsername, string racerTwoUsername)
        {
            IRacer racerOne = racers.FindBy(racerOneUsername);
            if (racerOne is null)
            {
                throw new ArgumentException($"Racer {racerOneUsername} cannot be found!");
            }

            IRacer racerTwo = racers.FindBy(racerTwoUsername);
            if (racerTwo is null)
            {
                throw new ArgumentException($"Racer {racerTwoUsername} cannot be found!");
            }

            return map.StartRace(racerOne, racerTwo);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var racer in racers.Models.OrderByDescending(r => r.DrivingExperience).ThenBy(r => r.Username))
            {
                sb.AppendLine(racer.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
