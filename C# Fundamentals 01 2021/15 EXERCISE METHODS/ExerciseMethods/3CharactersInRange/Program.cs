using System;

namespace _3CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that receives two characters and prints on a single line all the characters in between them according to ASCII.

            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            PrintCharacters(start, end);
        }

        static void PrintCharacters(char a, char b)
        {
            if (b < a)
            {
                char c = b;
                b = a;
                a = c;
            }
            a = (char)(a + 1);
            for (char i = a; i < b; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
