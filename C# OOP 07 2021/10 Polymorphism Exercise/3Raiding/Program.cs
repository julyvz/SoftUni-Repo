using System;
using System.Collections.Generic;

namespace _3Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> heroesTypes = new Dictionary<string, int>()
            {
                { "Druid", 80 },
                { "Paladin", 100},
                { "Rogue", 80 },
                { "Warrior", 100}
            };

            int n = int.Parse(Console.ReadLine());

            List<BaseHero> heroes = new List<BaseHero>();

            while (heroes.Count < n)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                if (!heroesTypes.ContainsKey(heroType))
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }

                BaseHero nextHero = null;

                switch (heroType)
                {
                    case "Druid":
                        nextHero = new Druid(heroName, heroesTypes[heroType]);
                        break;

                    case "Paladin":
                        nextHero = new Paladin(heroName, heroesTypes[heroType]);
                        break;

                    case "Rogue":
                        nextHero = new Rogue(heroName, heroesTypes[heroType]);
                        break;

                    case "Warrior":
                        nextHero = new Warrior(heroName, heroesTypes[heroType]);
                        break;
                }

                heroes.Add(nextHero);
            }

            int bossPower = int.Parse(Console.ReadLine());
            int raidGroupPower = 0;

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
                raidGroupPower += hero.Power;
            }

            Console.WriteLine(raidGroupPower >= bossPower ? "Victory!" : "Defeat...");
        }
    }
}
