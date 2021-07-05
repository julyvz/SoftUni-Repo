namespace Animals
{
    public class Kitten : Cat
    {
        private const string defGender = "Female";

        public Kitten(string name, int age) : base(name, age, defGender)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
