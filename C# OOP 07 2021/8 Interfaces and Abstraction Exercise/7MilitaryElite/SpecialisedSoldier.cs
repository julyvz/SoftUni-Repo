using System;
using System.Collections.Generic;
using System.Text;

namespace _7MilitaryElite
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;
        
        protected SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public string Corps
        {
            get 
            { 
                return corps;
            }
            set
            {
                if (value == "Airforces" || value == "Marines")
                {
                    corps = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
