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

            _7Tuple.Tuple<string, string> first = new _7Tuple.Tuple<string, string>(name, address);

            tokens1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            _7Tuple.Tuple<string, int> second = new _7Tuple.Tuple<string, int>(tokens1[0], int.Parse(tokens1[1]));

            tokens1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            _7Tuple.Tuple<int, double> third = new _7Tuple.Tuple<int, double>(int.Parse(tokens1[0]), double.Parse(tokens1[1]));

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
        }
    }
}
