namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double defGrams = 250;
        private const double defCal = 1000;
        private const decimal defPrice = 5M;
        
        public Cake(string name) : base(name, defPrice, defGrams, defCal)
        {
        }
    }
}
