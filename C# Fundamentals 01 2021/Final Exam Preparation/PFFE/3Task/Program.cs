using System;
using System.Linq;
using System.Collections.Generic;

namespace _3Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

            while (command != "Statistics")
            {
                string[] tokens = command.Split("->");
                string username = tokens[1];

                switch (tokens[0])
                {
                    case "Add":
                        if (users.ContainsKey(username))
                        {
                            Console.WriteLine($"{username} is already registered");
                        }
                        else
                        {
                            users.Add(username, new List<string>());
                        }
                        break;

                    case "Send":
                        users[username].Add(tokens[2]);
                        break;

                    case "Delete":
                        if (users.ContainsKey(username))
                        {
                            users.Remove(username);
                        }
                        else
                        {
                            Console.WriteLine($"{username} not found!");
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {users.Count}");
            foreach (var user in users.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var mail in user.Value)
                {
                    Console.WriteLine($" - {mail}");
                }
            }
        }
    }
}
