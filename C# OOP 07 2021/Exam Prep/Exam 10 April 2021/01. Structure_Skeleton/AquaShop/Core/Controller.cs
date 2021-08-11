using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Fish;
using AquaShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private List<IAquarium> aquariums;
        private DecorationRepository decorations;

        public Controller()
        {
            decorations = new DecorationRepository();
            aquariums = new List<IAquarium>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            switch (aquariumType)
            {
                case "FreshwaterAquarium":
                    aquariums.Add(new FreshwaterAquarium(aquariumName));
                    break;

                case "SaltwaterAquarium":
                    aquariums.Add(new SaltwaterAquarium(aquariumName));
                    break;

                default:
                    throw new InvalidOperationException("Invalid aquarium type.");
            }

            return $"Successfully added {aquariumType}.";
        }

        public string AddDecoration(string decorationType)
        {
            switch (decorationType)
            {
                case "Ornament":
                    decorations.Add(new Ornament());
                    break;

                case "Plant":
                    decorations.Add(new Plant());
                    break;

                default:
                    throw new InvalidOperationException("Invalid decoration type.");
            }

            return $"Successfully added {decorationType}.";
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            Fish fish;

            switch (fishType)
            {
                case "FreshwaterFish":
                    fish = new FreshwaterFish(fishName, fishSpecies, price);
                    break;

                case "SaltwaterFish":
                    fish = new SaltwaterFish(fishName, fishSpecies, price);
                    break;

                default:
                    throw new InvalidOperationException("Invalid fish type.");
            }

            var aquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);
            
            string result;

            if ((aquarium.GetType().Name == "SaltwaterAquarium" && fish.GetType().Name == "FreshwaterFish") || (aquarium.GetType().Name == "FreshwaterAquarium" && fish.GetType().Name == "SaltwaterFish"))
            {
                result = "Water not suitable.";
            }
            else
            {
                aquarium.AddFish(fish);
                result = $"Successfully added {fishType} to {aquariumName}.";
            }

            return result;
        }

        public string CalculateValue(string aquariumName)
        {
            var aquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            decimal value = aquarium.Fish.Sum(f => f.Price) + aquarium.Decorations.Sum(d => d.Price);

            return $"The value of Aquarium {aquariumName} is {value:F2}.";
        }

        public string FeedFish(string aquariumName)
        {
            var aquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);
            aquarium.Feed();

            return $"Fish fed: {aquarium.Fish.Count}";
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            var aquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);
            var decoration = decorations.FindByType(decorationType);

            if (decoration is null)
            {
                throw new InvalidOperationException($"There isn't a decoration of type {decorationType}.");
            }

            aquarium.Decorations.Add(decoration);
            decorations.Remove(decoration);

            return $"Successfully added {decorationType} to {aquariumName}.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var aquarium in aquariums)
            {
                sb.AppendLine(aquarium.GetInfo());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
