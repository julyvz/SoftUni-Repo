using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family theGoodFamily = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                Person current = new Person(tokens[0], int.Parse(tokens[1]));
                theGoodFamily.AddMember(current);
            }

            Person oldest = theGoodFamily.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
