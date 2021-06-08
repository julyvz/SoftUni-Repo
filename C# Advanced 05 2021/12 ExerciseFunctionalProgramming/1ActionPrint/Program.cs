using System;
using System.Linq;

namespace _1ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = x => Console.WriteLine(x);

            string[] names = Console.ReadLine().Split(' ');
            foreach (var name in names)
            {
                print(name);
            }
        }
    }
}
