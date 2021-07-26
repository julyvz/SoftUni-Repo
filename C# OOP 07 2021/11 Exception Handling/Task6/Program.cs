using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person pesho = new Person("Pesho", "Peshev", 24);

                Person noName = new Person(string.Empty, "Peshev", 31);

                Person noLastName = new Person("Ivan", string.Empty, 63);

                Person negativeAge = new Person("Stoyan", "Kolev", -1);

                Person tooOld = new Person("Iskren", "Ivanov", 145);
            }

            catch (ArgumentNullException ne)
            {
                Console.WriteLine(ne.Message);
            }

            catch (ArgumentOutOfRangeException oe)
            {
                Console.WriteLine(oe.Message);
            }

        }
    }
}
