using System;
using System.Collections.Generic;

namespace _5ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input;
            List<Person> myList = new List<Person>();
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];
                myList.Add(new Person(name, age, town));
            }
            int n = int.Parse(Console.ReadLine());

            Person target = myList[n - 1];
            int matches = 0;

            foreach (Person person in myList)
            {
                int result = person.CompareTo(target);
                if (result == 0)
                {
                    matches++;
                }
            }

            if (matches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {myList.Count - matches} {myList.Count}");
            }
        }
    }
}
