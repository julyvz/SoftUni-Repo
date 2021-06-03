using System;
using System.Collections.Generic;
using System.Linq;

namespace _5FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<(string name, int age)> people = new List<(string, int)>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                people.Add((tokens[0], int.Parse(tokens[1])));
            }
            string condition = Console.ReadLine();
            int targetAge = int.Parse(Console.ReadLine());
            string[] format = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Func<int, string, int, bool> meetCondition = (x, y, z) => 
            {
                string realDifference = "";
                if (x >= z)
                {
                    realDifference = "older";
                }
                else
                {
                    realDifference = "younger";
                }

                return realDifference == y;
            };

            foreach (var person in people)
            {
                if (meetCondition(person.age, condition, targetAge))
                {
                    List<string> output = new List<string>();
                    if (format.Contains("name"))
                    {
                        output.Add(person.name);
                    }
                    if (format.Contains("age"))
                    {
                        output.Add(person.age.ToString());
                    }
                    Console.WriteLine(string.Join(" - ", output));
                }
            }
        }
    }
}
