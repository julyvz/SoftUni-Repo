using System;

namespace _2KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            Func<string, string> giveTitle = x => string.Concat("Sir ", x);

            foreach (var name in names)
            {
                Console.WriteLine(giveTitle(name));
            }
        }
    }
}
