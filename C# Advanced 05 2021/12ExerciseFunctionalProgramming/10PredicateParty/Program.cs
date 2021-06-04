using System;
using System.Collections.Generic;
using System.Linq;

namespace _10PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            string command = "";
            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] tokens = command.Split();
                string condition = tokens[1];

                Func<string, bool> meetTheCondition = DefineTheCondition(condition, tokens[2]);

                for (int i = 0; i < names.Count; i++)
                {
                    if (meetTheCondition(names[i]))
                    {
                        if (tokens[0] == "Remove")
                        {
                            names.RemoveAt(i--);
                        }
                        else // Double
                        {
                            names.Insert(i, names[i++]);
                        }
                    }
                }
            }

            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine(string.Join(", ", names) + " are going to the party!");
            }
        }

        private static Func<string, bool> DefineTheCondition(string condition, string v)
        {
            switch (condition)
            {
                case "StartsWith":
                    return x => x.StartsWith(v);
                    break;
                case "EndsWith":
                    return x => x.EndsWith(v);
                    break;
                case "Length":
                    return x => x.Length == int.Parse(v);
                    break;
            }
            return x => true;
        }
    }
}
