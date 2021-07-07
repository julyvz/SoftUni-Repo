using System;
using System.Collections.Generic;
using System.Text;

namespace _7MilitaryElite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public List<Tuple<string, int>> Repairs { get; set; }

        public Engineer(int id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            Repairs = new List<Tuple<string, int>>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {Salary:F2}");
            sb.AppendLine($"Corps: {base.Corps}");
            sb.AppendLine("Repairs:");
            foreach (var repair in Repairs)
            {
                sb.AppendLine($"  Part Name: {repair.Item1} Hours Worked: {repair.Item2}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
