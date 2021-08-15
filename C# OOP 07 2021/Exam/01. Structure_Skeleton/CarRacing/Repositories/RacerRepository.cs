using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRacing.Repositories
{
    public class RacerRepository : IRepository<IRacer>
    {
        private List<IRacer> models;

        public RacerRepository()
        {
            models = new List<IRacer>();
        }
        
        public IReadOnlyCollection<IRacer> Models { get => models.AsReadOnly(); }

        public void Add(IRacer racer)
        {
            if (racer is null)
            {
                throw new ArgumentException("Cannot add null in Racer Repository");
            }

            models.Add(racer);
        }

        public IRacer FindBy(string property)
        {
            return models.FirstOrDefault(x => x.Username == property);
        }

        public bool Remove(IRacer racer)
        {
            return models.Remove(racer);
        }
    }
}
