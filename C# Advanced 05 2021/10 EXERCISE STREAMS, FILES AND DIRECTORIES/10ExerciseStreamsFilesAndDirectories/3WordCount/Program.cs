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
            string[] words = File.ReadAllLines("words.txt");
            Dictionary<string, int> timesByWord = new Dictionary<string, int>();
            foreach (var word in words)
            {
                timesByWord.Add(word, 0);
            }
            string text = File.ReadAllText("text.txt").ToLower();
            string[] wordsFromText = text.Split(new char[] { ' ', ',', '-', '.', '?', '!' }
            , StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in wordsFromText)
            {
                if (timesByWord.ContainsKey(word))
                {
                    timesByWord[word]++;
                }
            }

            List<string> output1 = new List<string>();
            List<string> output2 = new List<string>();
            foreach (var word in timesByWord)
            {
                output1.Add($"{word.Key} - {word.Value}");
            }

            File.WriteAllLines("actualResult.txt", output1);
            foreach (var word in timesByWord.OrderByDescending(x => x.Value))
            {
                output2.Add($"{word.Key} - {word.Value}");
            }
            File.WriteAllLines("expectedResult.txt", output2);
        }
    }
}
