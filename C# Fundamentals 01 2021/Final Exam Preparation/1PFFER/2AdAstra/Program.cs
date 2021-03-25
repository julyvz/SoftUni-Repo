using System;
using System.Text.RegularExpressions;

namespace _2AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([|#])(?<name>[A-Za-z\s]+)\1(?<date>\d\d/\d\d/\d\d)\1(?<cal>\d{1,5})\1";
            int totalCal = 0;

            MatchCollection foods = Regex.Matches(input, pattern);

            foreach (Match food in foods)
            {
                totalCal += int.Parse(food.Groups["cal"].Value);
            }
            int days = totalCal / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match food in foods)
            {
                Console.WriteLine($"Item: {food.Groups["name"].Value}, Best before: {food.Groups["date"].Value}, Nutrition: {food.Groups["cal"].Value}"); ;
            }
        }
    }
}
