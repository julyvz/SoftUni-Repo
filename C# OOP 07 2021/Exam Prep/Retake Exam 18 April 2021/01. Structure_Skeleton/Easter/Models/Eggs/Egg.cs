using Easter.Models.Eggs.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Eggs
{
    public class Egg : IEgg
    {
        private int energyRequired;

        public Egg(string name, int energyRequired)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Egg name cannot be null or empty.");
            }

            Name = name;
            EnergyRequired = energyRequired;
        }

        public string Name { get; }

        public int EnergyRequired
        {
            get => energyRequired;
            private set
            {
                if (value < 0)
                {
                    energyRequired = 0;
                }
                else
                {
                    energyRequired = value;
                }
            }
        }

        public void GetColored()
        {
            EnergyRequired -= 10;
        }

        public bool IsDone()
        {
            return energyRequired == 0;
        }
    }
}
