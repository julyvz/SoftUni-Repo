using System;

namespace _1DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int n = int.Parse(input);
                    Print(n);
                    break;
                case "real":
                    double s = double.Parse(input);
                    Print(s);
                    break;
                default:
                    Print(input);
                    break;
            }
        }

        private static void Print(int n)
        {
            Console.WriteLine(n * 2);
        }

        private static void Print(double n)
        {
            Console.WriteLine($"{n * 1.5:F2}");
        }

        private static void Print(string n)
        {
            Console.WriteLine("$"+n+"$");
        }
    }
}
