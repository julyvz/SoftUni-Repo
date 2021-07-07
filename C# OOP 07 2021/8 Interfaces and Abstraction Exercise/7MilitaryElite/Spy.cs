using System;
using System.Collections.Generic;
using System.Text;

namespace _7MilitaryElite
{
    public class Spy : Soldier, ISpy
    {
        public int CodeNumber { get; set; }

        public Spy(int id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id}");
            sb.AppendLine($"Code Number: {CodeNumber}");
            return sb.ToString().TrimEnd();
        }
    }
}
