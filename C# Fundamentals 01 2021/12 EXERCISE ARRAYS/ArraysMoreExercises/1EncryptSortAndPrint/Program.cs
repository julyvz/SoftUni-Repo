using System;

namespace _1EncryptSortAndPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] output = new int[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int stringLength = input.Length;
                foreach (var letter in input)
                {
                    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
                    {
                        output[i] += letter * stringLength;
                    }
                    else
                    {
                        output[i] += letter / stringLength;
                    }
                }
            }

            Array.Sort(output);
            foreach (var number in output)
            {
            Console.WriteLine(number);
            }
        }
    }
}
