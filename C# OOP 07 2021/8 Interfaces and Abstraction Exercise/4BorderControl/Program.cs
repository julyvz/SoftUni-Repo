using System;
using System.Collections.Generic;

namespace _4BorderControl
{
   public class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<IIdentifiable> subjects = new List<IIdentifiable>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                IIdentifiable next;
                if (tokens.Length == 2)
                {
                    next = new Robot(tokens[0], tokens[1]);
                    subjects.Add(next);
                }
                else
                {
                    next = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    subjects.Add(next);
                }
            }

            string toFInd = Console.ReadLine();

            foreach (var subject in subjects)
            {
                if (subject.Id.EndsWith(toFInd))
                {
                    Console.WriteLine(subject.Id);
                }
            }
        }
    }
}
