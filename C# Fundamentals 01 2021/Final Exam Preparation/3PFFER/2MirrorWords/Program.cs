using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([@#])(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";

            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            List<string> mirrorWords = new List<string>();
            foreach (Match match in matches)
            {
                string first = match.Groups["first"].Value;
                string second = match.Groups["second"].Value;
                string reversedSecond = new string(second.ToCharArray().Reverse().ToArray());

                if (first == reversedSecond)
                {
                    mirrorWords.Add(first + " <=> " + second);
                }
            }
            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorWords));
            }
        }
    }
}
