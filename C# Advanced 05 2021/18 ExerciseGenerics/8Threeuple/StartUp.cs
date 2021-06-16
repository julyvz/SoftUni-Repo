using System;

namespace _7Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] tokens1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string name = $"{tokens1[0]} {tokens1[1]}";
            string address = tokens1[2];
            string town = tokens1[3];

            _7Tuple.Threeuple<string, string, string> first = new _7Tuple.Threeuple<string, string, string>(name, address, town);

            tokens1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            _7Tuple.Threeuple<string, int, bool> second = new _7Tuple.Threeuple<string, int, bool>(tokens1[0], int.Parse(tokens1[1]), tokens1[2] == "drunk" ? true : false);

            tokens1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            _7Tuple.Threeuple<string, double, string> third = new _7Tuple.Threeuple<string, double, string>(tokens1[0], double.Parse(tokens1[1]), tokens1[2]);

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
        }
    }
}
