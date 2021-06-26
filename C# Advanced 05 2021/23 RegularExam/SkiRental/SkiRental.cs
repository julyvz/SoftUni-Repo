using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> skies;

        public SkiRental(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            skies = new List<Ski>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => skies.Count;

        public void Add(Ski ski)
        {
            if (skies.Count < Capacity)
            {
                skies.Add(ski);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Ski skiToRemove = skies.Find(x => x.Manufacturer == manufacturer && x.Model == model);
            if (skiToRemove == null)
            {
                return false;
            }
            else
            {
                skies.Remove(skiToRemove);
                return true;
            }
        }

        public Ski GetNewestSki()
        {
            return skies.OrderByDescending(x => x.Year).FirstOrDefault();
        }

        public Ski GetSki(string manufacturer, string model)
        {
            return skies.Where(x => x.Manufacturer == manufacturer && x.Model == model).FirstOrDefault();
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");
            foreach (var ski in skies)
            {
                sb.AppendLine(ski.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
