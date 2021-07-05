using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command;

            while ((command = Console.ReadLine()) != "Beast!")
            {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string gender = tokens[2];

                switch (command)
                {
                    case "Dog":
                        Dog dog = new Dog(name, age, gender);
                        Console.WriteLine(dog);
                        break;

                    case "Cat":
                        Cat cat = new Cat(name, age, gender);
                        Console.WriteLine(cat);
                        break;

                    case "Frog":
                        Frog frog = new Frog(name, age, gender);
                        Console.WriteLine(frog);
                        break;

                    case "Tomcat":
                        Tomcat tomcat = new Tomcat(name, age);
                        Console.WriteLine(tomcat);
                        break;

                    case "Kitten":
                        Kitten kitten = new Kitten(name, age);
                        Console.WriteLine(kitten);
                        break;
                }
            }
        }
    }
}
