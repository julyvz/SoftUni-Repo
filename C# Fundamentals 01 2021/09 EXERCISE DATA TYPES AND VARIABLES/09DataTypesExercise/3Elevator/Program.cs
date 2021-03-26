using System;

namespace _3Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPersons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = 0;
            courses = (int)Math.Ceiling((double)numPersons / capacity);
            Console.WriteLine(courses);
        }
    }
}
