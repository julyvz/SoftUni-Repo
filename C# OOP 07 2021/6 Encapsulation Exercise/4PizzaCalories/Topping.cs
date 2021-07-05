using System;
using System.Collections.Generic;
using System.Text;

namespace _4PizzaCalories
{
   public class Topping
    {
        private string type;
        private int weight;

        public Topping(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get => type; 
            private set
            {
                string value1 = value.ToLower();
                if (value1 == "meat" || value1 == "veggies" || value1 == "cheese" || value1 == "sauce")
                {
                    type = value;
                }
                else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
            }
        }

        public int Weight
        {
            get => weight;
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{type} weight should be in the range [1..50].");
                }
                else
                {
                    weight = value;
                }
            }
        }

        public double CaloriesPerGram
        {
            get
            {
                double calories = 2 * weight;
                double modifier = 1;

                switch (type.ToLower())
                {
                    case "meat":
                        modifier = 1.2;
                        break;

                    case "veggies":
                        modifier = 0.8;
                        break;

                    case "cheese":
                        modifier = 1.1;
                        break;

                    case "sauce":
                        modifier = 0.9;
                        break;
                }

                calories *= modifier;
                return calories;
            }
        }
    }
}
