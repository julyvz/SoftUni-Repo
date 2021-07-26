using System;
using System.Collections.Generic;
using System.Text;

namespace _4WildFarm
{
   public class Tiger : Feline
    {
        private const double weightIncrease = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override string AskForFood()
        {
            return "ROAR!!!";
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
