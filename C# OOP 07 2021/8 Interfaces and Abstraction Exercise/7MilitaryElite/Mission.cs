using System;

namespace _7MilitaryElite
{
    public class Mission : IMission
    {
        private string state;

        public Mission(string name, string state)
        {
            Name = name;
            State = state;
        }

        public string Name { get; set; }
        public string State
        {
            get { return state; }
            set
            {
                if (value == "inProgress" || value == "Finished")
                {
                    state = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public void CompleteMission()
        {
            state = "Finished";
        }

        public override string ToString()
        {
            return $"Code Name: {Name} State: {State}";
        }
    }
}
