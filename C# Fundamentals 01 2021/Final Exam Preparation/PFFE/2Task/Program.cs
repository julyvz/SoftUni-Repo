using System;
using System.Text.RegularExpressions;

namespace _2Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"^([\$%])([A-Z][a-z]{2,})\1: \[([\d]+)\]\|\[([\d]+)\]\|\[([\d]+)\]\|$";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string message = "";
                    for (int j = 3; j <= 5; j++)
                    {
                        message = message + (char)int.Parse(match.Groups[j].Value);
                    }
                    Console.WriteLine($"{match.Groups[2].Value}: " + message);
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
