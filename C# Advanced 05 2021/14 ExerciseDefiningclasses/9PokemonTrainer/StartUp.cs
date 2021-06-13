using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            string input = "";
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] tokens = input.Split();
                string trainerName = tokens[0];
                var pokemon = new Pokemon(tokens[1], tokens[2], int.Parse(tokens[3]));
                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }
                trainers[trainerName].Collection.Add(pokemon);
            }

            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var kvp in trainers)
                {
                    var trainer = kvp.Value;
                    if (trainer.Collection.Any(x => x.Element == input))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Collection.Count; i++)
                        {
                            trainer.Collection[i].Health -= 10;
                            if (trainer.Collection[i].Health <= 0)
                            {
                                trainer.Collection.RemoveAt(i--);
                            }
                        }
                    }
                }
            }

            foreach (var kvp in trainers.OrderByDescending(x => x.Value.Badges))
            {
                Console.WriteLine($"{kvp.Value.Name} {kvp.Value.Badges} {kvp.Value.Collection.Count}");
            }
        }
    }
}
