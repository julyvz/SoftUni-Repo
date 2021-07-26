namespace _4WildFarm
{
    public class Food
    {
        public Food(string foodType, int quantity)
        {
            FoodType = foodType;
            Quantity = quantity;
        }

        public string FoodType { get; set; }
        public int Quantity { get; set; }
    }
}
