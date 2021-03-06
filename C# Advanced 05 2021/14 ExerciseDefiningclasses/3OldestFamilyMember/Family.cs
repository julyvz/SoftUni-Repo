using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            Members = new List<Person>();
        }

        public List<Person> Members { get; set; }
        
        public void AddMember(Person member)
        {
            Members.Add(member);
        }

        public Person GetOldestMember()
        {
            return Members.OrderByDescending(x => x.Age).FirstOrDefault();
        }
    }
}
