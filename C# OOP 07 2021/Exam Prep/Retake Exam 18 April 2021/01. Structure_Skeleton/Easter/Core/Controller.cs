using Easter.Core.Contracts;
using Easter.Models.Bunnies;
using Easter.Repositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Easter.Models.Dyes;
using Easter.Models.Eggs;
using Easter.Models.Workshops;
using Easter.Models.Bunnies.Contracts;
using Easter.Utilities.Messages;
using Easter.Models.Workshops.Contracts;

namespace Easter.Core
{
    public class Controller : IController
    {
        private BunnyRepository bunnies;
        private EggRepository eggs;

        public Controller()
        {
            this.bunnies = new BunnyRepository();
            this.eggs = new EggRepository();
        }

        public string AddBunny(string bunnyType, string bunnyName)
        {
            switch (bunnyType)
            {
                case "HappyBunny":
                    bunnies.Add(new HappyBunny(bunnyName));
                    break;

                case "SleepyBunny":
                    bunnies.Add(new SleepyBunny(bunnyName));
                    break;

                default:
                    throw new InvalidOperationException("Invalid bunny type.");
            }

            return $"Successfully added {bunnyType} named {bunnyName}.";
        }

        public string AddDyeToBunny(string bunnyName, int power)
        {
            var bunny = bunnies.FindByName(bunnyName);
            if (bunny is null)
            {
                throw new InvalidOperationException("The bunny you want to add a dye to doesn't exist!");
            }

            bunny.AddDye(new Dye(power));

            return $"Successfully added dye with power {power} to bunny {bunnyName}!";
        }

        public string AddEgg(string eggName, int energyRequired)
        {
            eggs.Add(new Egg(eggName, energyRequired));

            return $"Successfully added egg: {eggName}!";
        }

        public string ColorEgg(string eggName)
        {
            var egg = eggs.FindByName(eggName);

            IWorkshop workshop = new Workshop();

            List<IBunny> suitableBunnies = bunnies.Models.Where(x => x.Energy >= 50).OrderByDescending(x => x.Energy).ToList();

            if (suitableBunnies.Any() == false)
            {
                throw new InvalidOperationException(ExceptionMessages.BunniesNotReady);
            }

            while (suitableBunnies.Any())
            {
                IBunny currentBunny = suitableBunnies.First();

                while (true)
                {
                    if (currentBunny.Energy == 0 || currentBunny.Dyes.All(x => x.IsFinished()))
                    {
                        suitableBunnies.Remove(currentBunny);
                        break;
                    }

                    workshop.Color(egg, currentBunny);

                    if (currentBunny.Energy == 0)
                    {
                        bunnies.Remove(currentBunny);
                    }

                    if (egg.IsDone())
                    {
                        break;
                    }
                }

                if (egg.IsDone())
                {
                    break;
                }
            }

            return $"Egg {eggName} is {(egg.IsDone() ? "done" : "not done")}.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{eggs.Models.Count(x => x.IsDone())} eggs are done!");
            sb.AppendLine("Bunnies info:");

            foreach (var bunny in bunnies.Models)
            {
                var countDyes = bunny.Dyes.Where(d => d.IsFinished() == false).ToList().Count;

                sb.AppendLine($"Name: {bunny.Name}");
                sb.AppendLine($"Energy: { bunny.Energy}");
                sb.AppendLine($"Dyes: {countDyes} not finished");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
