using System.Collections.Generic;
using System.Text;

namespace _7MilitaryElite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public List<Private> Privates { get; set; }

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
    : base(id, firstName, lastName, salary)
        {
            Privates = new List<Private>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {Salary:F2}");
            sb.AppendLine("Privates:");
            foreach (var private1 in Privates)
            {
                sb.AppendLine("  " + private1.ToString());
            }
            
            return sb.ToString().TrimEnd();
        }
    }
}
