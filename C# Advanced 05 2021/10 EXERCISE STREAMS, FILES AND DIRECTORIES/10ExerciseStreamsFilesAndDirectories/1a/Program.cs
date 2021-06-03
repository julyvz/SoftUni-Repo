using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _1a
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader("text.txt");

            string line;
            int row = -1;

            while ((line = reader.ReadLine()) != null)
            {
                row++;
                if (row % 2 == 0)
                {
                    char[] signs = new char[] { '-', ',', '.', '!', '?' };
                    StringBuilder sb = new StringBuilder();

                    foreach (char symbol in line)
                    {
                        if (signs.Contains(symbol))
                        {
                            sb.Append('@');
                        }
                        else
                        {
                            sb.Append(symbol);
                        }
                    }
                    line = sb.ToString();
                    string[] words = line.Split();
                    Console.WriteLine(string.Join(' ', words.Reverse()));
                }
            }
        }
    }
}
