using System;
using System.Text.RegularExpressions;

namespace _2FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"^@[#]+(?<item>[A-Z][A-Za-z\d]{4,}[A-Z])@[#]+$";
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var match = Regex.Match(input, pattern);
                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    MatchCollection group = Regex.Matches(match.Groups["item"].Value, @"\d");
                    if (group.Count == 0)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine("Product group: " + string.Join("", group));
                    }
                }
            }            
        }
    }
}
