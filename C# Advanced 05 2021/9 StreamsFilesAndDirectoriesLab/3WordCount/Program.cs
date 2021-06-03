using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words;
            using (var reader = new StreamReader("words.txt"))
            {
                words = reader.ReadLine().Split();
            }

            string input = "";
            using (var reader = new StreamReader("text.txt"))
            {
                input = reader.ReadToEnd().ToLower();
            }
            string[] wordsFromText = input.Split(new char[] { ' ', ',', '-', '.', '?', '!' }
            , StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> numberOfWords = new Dictionary<string, int>();
            foreach (var word in words)
            {
                numberOfWords.Add(word, 0);
            }

            foreach (var word in wordsFromText)
            {
                if (numberOfWords.ContainsKey(word))
                {
                    numberOfWords[word]++;
                }
            }

            using (var writer = new StreamWriter("Output.txt"))
            {
                foreach (var word in numberOfWords.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
