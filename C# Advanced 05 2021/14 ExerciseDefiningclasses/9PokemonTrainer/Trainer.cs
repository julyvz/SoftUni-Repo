using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Trainer
    {
        public Trainer(string trainerName)
        {
            Name = trainerName;
            Badges = 0;
            Collection = new List<Pokemon>();
        }
        
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Collection { get; set; }
    }
}
