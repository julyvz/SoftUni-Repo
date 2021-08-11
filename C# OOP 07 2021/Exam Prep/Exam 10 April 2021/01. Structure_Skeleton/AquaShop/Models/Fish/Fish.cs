using AquaShop.Models.Fish.Contracts;
using System;

namespace AquaShop.Models.Fish
{
    public abstract class Fish : IFish
    {
        private decimal price;

        protected Fish(string name, string species, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Fish name cannot be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(species))
            {
                throw new ArgumentException("Fish species cannot be null or empty.");
            }

            Name = name;
            Species = species;
            Price = price;
        }

        public string Name { get; }

        public string Species { get; }

        public int Size { get; protected set; } // PP!!!

        public decimal Price
        { 
            get => price;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fish price cannot be below or equal to 0.");
                }

                price = value;
            }
        }

        public abstract void Eat();        
    }
}
