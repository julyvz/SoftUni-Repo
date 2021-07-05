using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                name = value;
            }
        }


        public double Rating
        {
            get
            {
                if (players.Count == 0)
                {
                    return 0;
                }
                else
                {
                    return players.Average(x => x.SkillLevel);
                }
            }
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            Player toBeRemoved = players.Find(x => x.Name == playerName);

            if (toBeRemoved is null)
            {
                Console.WriteLine($"Player {playerName} is not in {this.Name} team.");
            }
            else
            {
                players.Remove(toBeRemoved);
            }
        }
    }
}
