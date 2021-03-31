using System;
using System.Linq;
using System.Collections.Generic;

namespace _3HeroesOfCodeAndLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int[]> heroes = new Dictionary<string, int[]>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                heroes.Add(tokens[0], new[] { int.Parse(tokens[1]), int.Parse(tokens[2]) });
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split(" - ");
                string name = tokens[1];

                switch (tokens[0])
                {
                    case "CastSpell":
                        int mana = int.Parse(tokens[2]);
                        if (mana > heroes[name][1])
                        {
                            Console.WriteLine($"{name} does not have enough MP to cast {tokens[3]}!");
                        }
                        else
                        {
                            heroes[name][1] -= mana;
                            Console.WriteLine($"{name} has successfully cast {tokens[3]} and now has {heroes[name][1]} MP!");
                        }
                        break;

                    case "TakeDamage":
                        int damage = int.Parse(tokens[2]);
                        heroes[name][0] -= damage;
                        if (heroes[name][0] > 0)
                        {
                            Console.WriteLine($"{name} was hit for {damage} HP by {tokens[3]} and now has {heroes[name][0]} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} has been killed by {tokens[3]}!");
                            heroes.Remove(name);
                        }
                        break;

                    case "Recharge":
                        int amount = int.Parse(tokens[2]);
                        if (amount + heroes[name][1] > 200)
                        {
                            amount = 200 - heroes[name][1];
                        }
                        heroes[name][1] += amount;
                        Console.WriteLine($"{name} recharged for {amount} MP!");
                        break;

                    case "Heal":
                        amount = int.Parse(tokens[2]);
                        if (amount + heroes[name][0] > 100)
                        {
                            amount = 100 - heroes[name][0];
                        }
                        heroes[name][0] += amount;
                        Console.WriteLine($"{name} healed for {amount} HP!");
                        break;
                }
                command = Console.ReadLine();
            }
            foreach (var hero in heroes.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }
        }
    }
}
