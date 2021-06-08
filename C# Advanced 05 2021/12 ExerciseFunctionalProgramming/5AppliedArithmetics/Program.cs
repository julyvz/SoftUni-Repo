using System;
using System.Linq;

namespace _5AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = "";
            Func<int, int> add = n => n + 1;
            Func<int, int> multiply = n => n * 2;
            Func<int, int> subtract = n => n - 1;

            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] = add(numbers[i]);
                        }
                        break;

                    case "multiply":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] = multiply(numbers[i]);
                        }
                        break;

                    case "subtract":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] = subtract(numbers[i]);
                        }
                        break;

                    case "print":
                        Console.WriteLine(string.Join(' ', numbers));
                        break;

                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }
    }
}
