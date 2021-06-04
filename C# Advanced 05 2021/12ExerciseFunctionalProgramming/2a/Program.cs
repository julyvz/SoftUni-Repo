using System;

namespace _2a
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            Action<string> giveTitleAndPrint = x => Console.WriteLine("Sir " + x);

            foreach (var name in names)
            {
                giveTitleAndPrint(name);
            }
        }
    }
}
