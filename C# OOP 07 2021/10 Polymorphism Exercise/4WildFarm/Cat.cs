using System;
using System.Collections.Generic;
using System.Text;

namespace _4WildFarm
{
    public class Cat : Feline
    {
        private const double weightIncrease = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override string AskForFood()
        {
            return "Meow";
        }

        public override void Eat(Food food)
        {
            if (food.FoodType == "Vegetable" || food.FoodType == "Meat")
            {
                FoodEaten += food.Quantity;
                Weight += food.Quantity * weightIncrease;
                return;
            }

            throw new ArgumentException();
        }
    }
}
