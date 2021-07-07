using System;
using System.Collections.Generic;
using System.Text;

namespace _7MilitaryElite
{
    public abstract class Soldier : ISoldier
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Soldier(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
