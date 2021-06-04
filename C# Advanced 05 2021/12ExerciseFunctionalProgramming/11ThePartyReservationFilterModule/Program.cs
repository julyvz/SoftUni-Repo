using System;
using System.Collections.Generic;
using System.Linq;

namespace _11ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            List<string> filters = new List<string>();

            string input = "";
            while ((input = Console.ReadLine()) != "Print")
            {
                string[] tokens = input.Split(';');
                string command = tokens[0];
                string filterType = tokens[1];
                string filterParameter = tokens[2];
                string filter = filterType + ";" + filterParameter;

                if (command == "Add filter")
                {
                    filters.Add(filter);
                }
                else
                {
                    filters.Remove(filter);
                }
            }

            foreach (var filter in filters)
            {
                string[] tokens = filter.Split(';');
                string filterType = tokens[0];
                string filterParameter = tokens[1];
                Func<string, bool> predicat = GetPredicate(filterType, filterParameter);
                names = names.Where(predicat).ToList();
            }

            Console.WriteLine(string.Join(" ", names));
        }

        private static Func<string, bool> GetPredicate(string filterType, string filterParameter)
        {
            switch (filterType)
            {
                case "Starts with":
                    return x => !x.StartsWith(filterParameter);
                case "Ends with":
                    return x => !x.EndsWith(filterParameter);
                case "Length":
                    return x => x.Length != int.Parse(filterParameter);
                case "Contains":
                    return x => !x.Contains(filterParameter);
                default:
                    throw new ArgumentException("Invalid command type: " + filterType);
            }
        }
    }
}
