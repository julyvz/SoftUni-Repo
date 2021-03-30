using System;
using System.Text.RegularExpressions;

namespace _2DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([=\/])(?<place>[A-Z][A-Za-z]{2,})\1";

            string input = Console.ReadLine();

            MatchCollection places = Regex.Matches(input, pattern);
            string[] towns = new string[places.Count];
            int count = 0;
            int points = 0;
            foreach (Match place in places)
            {
                towns[count++] = place.Groups["place"].Value;
                points += place.Groups["place"].Value.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", towns)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
