using System;
using System.Collections.Generic;

namespace _5BirthdayCelebrations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<IBitrhable> subjects = new List<IBitrhable>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                IBitrhable next;
                if (tokens[0] == "Pet")
                {
                    next = new Pet(tokens[1], tokens[2]);
                    subjects.Add(next);
                }
                else if (tokens[0] == "Citizen")
                {
                    next = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
                    subjects.Add(next);
                }
            }

            string toFInd = Console.ReadLine();

            foreach (var subject in subjects)
            {
                if (subject.Birthdate.EndsWith(toFInd))
                {
                    Console.WriteLine(subject.Birthdate);
                }
            }
        }
    }
}
