using System;
using System.Linq;
using System.Collections.Generic;

namespace _3MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string querie = Console.ReadLine();
                string[] tokens = querie.Split();

                switch (tokens[0])
                {
                    case "1":
                        numbers.Push(int.Parse(tokens[1]));
                        break;
                    case "2":
                        numbers.Pop();
                        break;
                    case "3":
                        if (numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.Max());
                        }
                        break;
                    case "4":
                        if (numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.Min());
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
