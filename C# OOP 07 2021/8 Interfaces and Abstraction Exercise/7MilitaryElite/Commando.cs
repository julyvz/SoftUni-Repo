using System;
using System.Collections.Generic;
using System.Text;

namespace _7MilitaryElite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public List<Mission> Missions { get; set; }

        public Commando(int id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            Missions = new List<Mission>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {Salary:F2}");
            sb.AppendLine($"Corps: {base.Corps}");
            sb.AppendLine("Missions:");
            foreach (var mission in Missions)
            {
                sb.AppendLine($"  {mission}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
