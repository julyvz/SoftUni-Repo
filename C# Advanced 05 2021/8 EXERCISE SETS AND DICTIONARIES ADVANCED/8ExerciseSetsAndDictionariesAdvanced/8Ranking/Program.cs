using System;
using System.Collections.Generic;
using System.Linq;

namespace _8Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1;
            Dictionary<string, string> passwordsByContests = new Dictionary<string, string>();

            while ((input1 = Console.ReadLine()) != "end of contests")
            {
                string[] tokens = input1.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string contest = tokens[0];
                string password = tokens[1];
                passwordsByContests.Add(contest, password);
            }

            string input2;
            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();

            while ((input2 = Console.ReadLine()) != "end of submissions")
            {
                string[] tokens = input2.Split("=>");
                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (passwordsByContests.ContainsKey(contest) && password == passwordsByContests[contest])
                {
                    if (!students.ContainsKey(username))
                    {
                        students.Add(username, new Dictionary<string, int>());
                    }
                    if (students[username].ContainsKey(contest))
                    {
                        if (students[username][contest] < points)
                        {
                            students[username][contest] = points;
                        }
                    }
                    else
                    {
                        students[username].Add(contest, points);
                    }
                }
            }

            int maxPoints = int.MinValue;
            string bestCandidate = "";
            foreach (var student in students)
            {
                int points = 0;
                foreach (var contest in student.Value)
                {
                    points += contest.Value;
                }
                
                if (points > maxPoints)
                {
                    maxPoints = points;
                    bestCandidate = student.Key;
                }
            }        

            Console.WriteLine($"Best candidate is {bestCandidate} with total {maxPoints} points.");

            Console.WriteLine("Ranking:");
            foreach (var student in students.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{student.Key}");
                foreach (var contest in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
