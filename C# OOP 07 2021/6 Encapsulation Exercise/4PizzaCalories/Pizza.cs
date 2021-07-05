using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4PizzaCalories
{
   public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name)
        {
            Name = name;
            toppings = new List<Topping>();
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                name = value;
            }
        }

        public Dough Dough
        {
            get => dough;
            set
            {
                dough = value;
            }
        }

        public double TotalCalories
        {
            get
            {
                double cals = dough.CaloriesPerGram;
                cals += toppings.Sum(x => x.CaloriesPerGram);

                return cals;
            }
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            else
            {
                toppings.Add(topping);
            }
        }

        
    }
}
