using System;
using System.Collections.Generic;
using System.Text;

namespace _5FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            if (endurance < 0 || endurance > 100)
            {
                throw new ArgumentException("Endurance should be between 0 and 100.");
            }
            this.endurance = endurance;

            if (sprint < 0 || sprint > 100)
            {
                throw new ArgumentException("Sprint should be between 0 and 100.");
            }
            this.sprint = sprint;

            if (dribble < 0 || dribble > 100)
            {
                throw new ArgumentException("Dribble should be between 0 and 100.");
            }
            this.dribble = dribble;

            if (passing < 0 || passing > 100)
            {
                throw new ArgumentException("Passing should be between 0 and 100.");
            }
            this.passing = passing;

            if (shooting < 0 || shooting > 100)
            {
                throw new ArgumentException("Shooting should be between 0 and 100.");
            }
            this.shooting = shooting;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                name = value;
            }
        }

        public double SkillLevel
        {
            get
            {
                return (endurance + sprint + dribble + passing + shooting) / 5.0;
            }
        }
    }
}
