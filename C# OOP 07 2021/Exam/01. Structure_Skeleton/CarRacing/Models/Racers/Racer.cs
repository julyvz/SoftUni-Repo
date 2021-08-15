using CarRacing.Models.Cars.Contracts;
using CarRacing.Models.Racers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Racers
{
    public abstract class Racer : IRacer
    {
        private int drivingExperience;
        private ICar car;

        protected Racer(string username, string racingBehavior, int drivingExperience, ICar car)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username cannot be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(racingBehavior))
            {
                throw new ArgumentException("Racing behavior cannot be null or empty.");
            }

            Username = username;
            RacingBehavior = racingBehavior;
            DrivingExperience = drivingExperience;
            Car = car;
        }

        public string Username { get; }

        public string RacingBehavior { get; }

        public int DrivingExperience
        {
            get => drivingExperience;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Racer driving experience must be between 0 and 100.");
                }

                drivingExperience = value;
            }
        }

        public ICar Car
        {
            get => car;
            set
            {
                if (value is null)
                {
                    throw new ArgumentException("Car cannot be null or empty.");
                }

                car = value;
            }
        }

        public bool IsAvailable()
        {
            return Car.FuelAvailable >= Car.FuelConsumptionPerRace;  // PP >= or >
        }

        public virtual void Race()
        {
            Car.Drive();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{GetType().Name}: {Username}");
            sb.AppendLine($"--Driving behavior: {RacingBehavior}");
            sb.AppendLine($"--Driving experience: {drivingExperience}");
            sb.AppendLine($"--Car: {Car.Make} {Car.Model} ({Car.VIN})");
            
            return sb.ToString().TrimEnd();
        }
    }
}
