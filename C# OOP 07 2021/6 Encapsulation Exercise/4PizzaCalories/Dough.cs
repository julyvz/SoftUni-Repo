using System;
using System.Collections.Generic;
using System.Text;

namespace _4PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string FlourType
        {
            get => flourType;
            private set
            {
                if (value == "white" || value == "wholegrain")
                {
                    flourType = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }

        }

        public string BakingTechnique
        {
            get => bakingTechnique;
            private set
            {
                if (value == "crispy" || value == "chewy" || value == "homemade")
                {
                    bakingTechnique = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        public int Weight
        {
            get => weight;
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
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
                if (this.flourType == "white")
                {
                    calories *= 1.5;
                }
                if (this.bakingTechnique == "crispy")
                {
                    calories *= 0.9;
                }
                else if (this.bakingTechnique == "chewy")
                {
                    calories *= 1.1;
                }

                return calories;
            }
        }
    }
}
