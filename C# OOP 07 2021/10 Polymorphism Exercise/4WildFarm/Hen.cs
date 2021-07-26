namespace _4WildFarm
{
    public class Hen : Bird
    {
        private const double weightIncrease = 0.35;

        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override string AskForFood()
        {
            return "Cluck";
        }

        public override void Eat(Food food)
        {
            FoodEaten += food.Quantity;
            Weight += food.Quantity * weightIncrease;
        }
    }
}
