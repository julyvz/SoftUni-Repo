using System;

namespace _4WildFarm
{
    public class Mouse : Mammal
    {
        private const double weightIncrease = 0.10;

        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override string AskForFood()
        {
            return "Squeak";
        }

        public override void Eat(Food food)
        {
            if (food.FoodType == "Vegetable" || food.FoodType == "Fruit")
            {
                FoodEaten += food.Quantity;
                Weight += food.Quantity * weightIncrease;
                return;
            }

            throw new ArgumentException();
        }
    }
}
