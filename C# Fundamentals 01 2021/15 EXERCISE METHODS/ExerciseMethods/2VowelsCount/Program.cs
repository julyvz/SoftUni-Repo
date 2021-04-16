using System;

namespace _2VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that receives a single string and prints the count of the vowels.

            string input = Console.ReadLine();

            Console.WriteLine(CountVowels(input));
        }

        static int CountVowels(string str)
        {
            int vowels = 0;
            char[] allVowels = { 'a', 'e', 'o', 'u', 'i', 'A', 'E', 'O', 'U', 'I' };
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < allVowels.Length; j++)
                {
                    if (str[i] == allVowels[j])
                    {
                        vowels++;
                        break;
                    }
                }
            }
            return vowels;
        }
    }
}
