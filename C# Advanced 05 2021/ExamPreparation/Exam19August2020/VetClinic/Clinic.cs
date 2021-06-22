using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> pets;
        
        public Clinic(int capacity)
        {
            Capacity = capacity;
            pets = new List<Pet>();
        }

        public int Capacity { get; set; }
        public int Count => pets.Count;

        public void Add(Pet pet)
        {
            if (pets.Count < Capacity)
            {
                pets.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            Pet toBeRemoved = pets.FirstOrDefault(pet => pet.Name == name);
            if (toBeRemoved == null)
            {
                return false;
            }
            else
            {
                pets.Remove(toBeRemoved);
                return true;
            }
        }

        public Pet GetPet(string name, string owner)
        {
            return pets.FirstOrDefault(pet => pet.Name == name && pet.Owner == owner);
        }

        public Pet GetOldestPet()
        {
            return pets.OrderByDescending(x => x.Age).First();
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (var pet in pets)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
