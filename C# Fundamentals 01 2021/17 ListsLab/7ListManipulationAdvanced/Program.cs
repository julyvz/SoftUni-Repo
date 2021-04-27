using System;
using System.Collections.Generic;
using System.Linq;

namespace _7ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] initialNumbers = new int[numbers.Count];
            numbers.CopyTo(initialNumbers);

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

                    case "Contains":
                        if (numbers.Contains(int.Parse(commandAsArray[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        List<int> even = numbers.Where(n => n % 2 == 0).ToList();
                        Console.WriteLine(string.Join(' ', even));
                        break;
                    case "PrintOdd":
                        List<int> odd = numbers.Where(n => n % 2 != 0).ToList();
                        Console.WriteLine(string.Join(' ', odd));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        List<int> output = new List<int>();
                        string condition = commandAsArray[1];
                        int limit = int.Parse(commandAsArray[2]);
                        if (condition == ">")
                        {
                        output = numbers.Where(n => n > limit).ToList();
                        }
                        else if (condition == "<")
                        {
                            output = numbers.Where(n => n < limit).ToList();
                        }
                        else if (condition == "<")
                        {
                            output = numbers.Where(n => n < limit).ToList();
                        }
                        else if (condition == ">=")
                        {
                            output = numbers.Where(n => n >= limit).ToList();
                        }
                        else if (condition == "<=")
                        {
                            output = numbers.Where(n => n <= limit).ToList();
                        }
                        Console.WriteLine(string.Join(' ', output));
                        break;
                }
                command = Console.ReadLine();
            }
            bool areEqual = Enumerable.SequenceEqual(numbers, initialNumbers);

            if (!areEqual)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}

