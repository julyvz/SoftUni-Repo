using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
   public abstract class Animal
    {
        
        private int age;
        private string gender;

        public string Name { get; set; }

        public int Age
        {
            get { return age; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                age = value;
            }
        }

        public string Gender
        {
            get { return gender; }
            set {
                if (value == "Male" || value == "Female")
                {
                    this.gender = value;
                }
                else
                {
                    throw new ArgumentException("Invalid input!");
                }
            }
        }

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public virtual string ProduceSound()
        {
            return string.Empty;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.GetType().Name);
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.AppendLine(this.ProduceSound());
            
            return sb.ToString().TrimEnd();
        }
    }
}
