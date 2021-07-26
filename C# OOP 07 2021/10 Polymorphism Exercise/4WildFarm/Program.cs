using System;
using System.Collections.Generic;

namespace _4WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string input;


            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(); // Animal
                Animal nextAnimal = null;

                switch (tokens[0])
                {
                    case "Owl":
                        nextAnimal = new Owl(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3]));
                        break;

                    case "Hen":
                        nextAnimal = new Hen(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3]));
                        break;

                    case "Mouse":
                        nextAnimal = new Mouse(tokens[1], double.Parse(tokens[2]), tokens[3]);
                        break;

                    case "Dog":
                        nextAnimal = new Dog(tokens[1], double.Parse(tokens[2]), tokens[3]);
                        break;

                    case "Cat":
                        nextAnimal = new Cat(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]);
                        break;

                    case "Tiger":
                        nextAnimal = new Tiger(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]);
                        break;
                }
                Console.WriteLine(nextAnimal.AskForFood());
                animals.Add(nextAnimal);

                tokens = Console.ReadLine().Split(); // Food
                Food currFood = new Food(tokens[0], int.Parse(tokens[1]));

                try
                {
                    nextAnimal.Eat(currFood);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"{nextAnimal.GetType().Name} does not eat {currFood.FoodType}!");
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
