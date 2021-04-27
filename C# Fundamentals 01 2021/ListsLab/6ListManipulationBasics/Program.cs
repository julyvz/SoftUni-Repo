using System;
using System.Collections.Generic;
using System.Linq;

namespace _6ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandAsArray = command.Split();
                switch (commandAsArray[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(commandAsArray[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(commandAsArray[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(commandAsArray[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(commandAsArray[2]), int.Parse(commandAsArray[1]));
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
