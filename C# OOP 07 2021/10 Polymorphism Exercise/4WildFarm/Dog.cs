using System;
using System.Collections.Generic;
using System.Text;

namespace _4WildFarm
{
    public class Dog : Mammal
    {
        private const double weightIncrease = 0.40;

        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override string AskForFood()
        {
            return "Woof!";
        }

        public override void Eat(Food food)
        {
            if (food.FoodType != "Meat")
            {
                throw new ArgumentException();
            }

            FoodEaten += food.Quantity;
            Weight += food.Quantity * weightIncrease;
        }
    }
}
