using System;
using System.Collections.Generic;

namespace _5FootballTeamGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split(';');

                string currTeamName = tokens[1];
                try
                {
                    switch (tokens[0])
                    {
                        case "Team":
                            Team nextTeam = new Team(currTeamName);
                            teams.Add(nextTeam);
                            break;

                        case "Add":
                            if (teams.Find(x => x.Name == currTeamName) is null)
                            {
                                Console.WriteLine($"Team {currTeamName} does not exist.");
                                continue;
                            }

                            string currPlayerName = tokens[2];
                            int endurance = int.Parse(tokens[3]);
                            int sprint = int.Parse(tokens[4]);
                            int dribble = int.Parse(tokens[5]);
                            int passing = int.Parse(tokens[6]);
                            int shooting = int.Parse(tokens[7]);

                            Player nextPlayer = new Player(currPlayerName, endurance, sprint, dribble, passing, shooting);

                            teams.Find(x => x.Name == currTeamName).AddPlayer(nextPlayer);
                            break;

                        case "Remove":
                            currPlayerName = tokens[2];

                            Team currTeam = teams.Find(x => x.Name == currTeamName);
                            currTeam.RemovePlayer(currPlayerName);
                            break;

                        case "Rating":
                            if (teams.Find(x => x.Name == currTeamName) is null)
                            {
                                Console.WriteLine($"Team {currTeamName} does not exist.");
                                continue;
                            }

                            Console.WriteLine($"{currTeamName} - {Math.Round(teams.Find(x => x.Name == currTeamName).Rating)}");

                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
