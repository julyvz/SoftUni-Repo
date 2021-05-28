using System;
using System.Collections.Generic;

namespace _5CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> letters = new SortedDictionary<char, int>();

            foreach (char letter in input)
            {
                if (!letters.ContainsKey(letter))
                {
                    letters.Add(letter, 0);
                }
                letters[letter]++;
            }

            foreach (var letter in letters)
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
