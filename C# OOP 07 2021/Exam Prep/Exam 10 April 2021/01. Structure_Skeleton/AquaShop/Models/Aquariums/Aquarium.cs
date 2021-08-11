using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private List<IFish> fishes;
        private List<IDecoration> decorations;
        
        protected Aquarium(string name, int capacity)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Aquarium name cannot be null or empty.");
            }

            Name = name;
            Capacity = capacity;

            fishes = new List<IFish>();
            decorations = new List<IDecoration>();
        }

        public string Name { get; }

        public int Capacity { get; }

        public int Comfort { get => Decorations.Sum(x => x.Comfort); }

        public ICollection<IDecoration> Decorations { get => decorations; }

        public ICollection<IFish> Fish { get => fishes; }

        public void AddDecoration(IDecoration decoration)
        {
            decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if (fishes.Count >= Capacity)
            {
                throw new InvalidOperationException("Not enough capacity.");
            }

            fishes.Add(fish);
        }

        public void Feed()
        {
            foreach (var fish in fishes)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {
            List<string> names = new List<string>();
            foreach (var fish in fishes)
            {
                names.Add(fish.Name);
            }
            
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Name} ({this.GetType().Name}):");
            sb.Append("Fish: ");
            sb.AppendLine(fishes.Count == 0 ? "none" : string.Join(", ", names));
            sb.AppendLine($"Decorations: {decorations.Count}");
            sb.AppendLine($"Comfort: {Comfort}");

            return sb.ToString().TrimEnd();
        }

        public bool RemoveFish(IFish fish)
        {
            return fishes.Remove(fish);
        }
    }
}
