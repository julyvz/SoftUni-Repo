using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes;
using Easter.Models.Dyes.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Bunnies
{
    public abstract class Bunny : IBunny
    {
        private int energy;

        protected Bunny(string name, int energy)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Bunny name cannot be null or empty.");
            }

            Name = name;
            Energy = energy;

            Dyes = new List<IDye>();
        }

        public string Name { get; }

        public int Energy
        {
            get => energy;
            protected set
            {
                if (value < 0)
                {
                    energy = 0;
                }
                else
                {
                    energy = value;
                }
            }
        }

        public ICollection<IDye> Dyes { get ; }

        public void AddDye(IDye dye)
        {
            Dyes.Add(dye);
        }

        public virtual void Work()
        {
            Energy -= 10;
        }
    }
}
