using System;

namespace _04ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            string output = sb.ToString();

            Console.WriteLine(output);
        }
    }
}
