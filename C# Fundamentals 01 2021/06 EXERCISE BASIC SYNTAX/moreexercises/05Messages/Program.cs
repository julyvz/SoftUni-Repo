using System;

namespace _05Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input, output = "";
            int numberOfDigits;
            int mainDigit;
            int offset, index;
            char currentChar;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                numberOfDigits = input.Length;
                mainDigit = int.Parse(input) % 10;
                offset = (mainDigit - 2) * 3;
                if (mainDigit == 0)
                {
                    output += " ";
                }
                else
                {
                if (mainDigit == 8 || mainDigit == 9) offset++;
                index = offset + numberOfDigits - 1;
                currentChar = (char)(97 + index);
                output += (currentChar.ToString());
                }
            }
            Console.WriteLine(output);
        }
    }
}
