using System;
using System.Collections.Generic;
using System.Linq;

namespace _7TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, List<string>> followers = new Dictionary<string, List<string>>();
            Dictionary<string, int> following = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] tokens = input.Split();
                string currentVlogger = tokens[0];
                string command = tokens[1];

                if (command == "joined")
                {
                    if (!followers.ContainsKey(currentVlogger))
                    {
                        followers.Add(currentVlogger, new List<string>());
                        following.Add(currentVlogger, 0);
                    }
                }
                else // command == "followed"
                {
                    string currentFollowed = tokens[2];
                    if (!followers.ContainsKey(currentVlogger) || !followers.ContainsKey(currentFollowed) || (currentVlogger == currentFollowed))
                    {
                        continue;
                    }
                    if (!followers[currentFollowed].Contains(currentVlogger))
                    {
                        followers[currentFollowed].Add(currentVlogger);
                        following[currentVlogger]++;
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {followers.Count} vloggers in its logs.");
            int i = 1;
            foreach (var vlogger in followers.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => following[x.Key]))
            {
                Console.WriteLine($"{i++}. {vlogger.Key} : {vlogger.Value.Count} followers, {following[vlogger.Key]} following");
                if (i == 2)
                {
                    foreach (var follower in vlogger.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
            }
        }
    }
}
