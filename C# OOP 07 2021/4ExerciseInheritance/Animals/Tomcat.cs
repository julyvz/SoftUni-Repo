namespace Animals
{
    public class Tomcat : Cat
    {
        private const string defGender = "Male";

        public Tomcat(string name, int age) : base(name, age, defGender)
        {
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
