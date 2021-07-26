using System;

namespace _4WildFarm
{
    public class Owl : Bird
    {
        private const double weightIncrease = 0.25;
        
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override string AskForFood()
        {
            return "Hoot Hoot";
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
