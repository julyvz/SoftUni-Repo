using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roster = new List<Player>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => roster.Count;

        public void AddPlayer(Player player)
        {
            if (roster.Count < Capacity)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player playerToBeRemoved = roster.FirstOrDefault(x => x.Name == name);
            if (playerToBeRemoved != null)
            {
                roster.Remove(playerToBeRemoved);
                return true;
            }
            return false;
        }

        public void PromotePlayer(string name)
        {
            Player playerToBePromoted = roster.FirstOrDefault(x => x.Name == name);
            if (playerToBePromoted != null)
            {
                playerToBePromoted.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            Player playerToBeDemoted = roster.FirstOrDefault(x => x.Name == name);
            if (playerToBeDemoted != null)
            {
                playerToBeDemoted.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string classs)
        {
            List<Player> kicked = new List<Player>();
            for (int i = 0; i < roster.Count; i++)
            {
                if (roster[i].Class == classs)
                {
                    kicked.Add(roster[i]);
                    roster.RemoveAt(i--);                    
                }
            }

            return kicked.ToArray();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            foreach (Player player in roster)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
