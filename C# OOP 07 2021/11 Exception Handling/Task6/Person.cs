using System;
using System.Collections.Generic;
using System.Text;

namespace Task6
{
   public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "First name cannot be empty or space.");
                }

                firstName = value;
            }
        }


        public string LastName
        {
            get { return lastName; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Last name cannot be empty or space.");
                }

                lastName = value;
            }
        }

        public int Age
        {
            get { return age; }
            set {
                if (value < 0 || value > 130)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Age should be in the range [0 ... 130].");
                }
                age = value;
            }
        }

    }
}
