using System;
using System.IO;
using System.Linq;

namespace _1EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("text.txt");

            string line;
            int row = -1;

            using (reader)
            {

                while ((line = reader.ReadLine()) != null)
                {
                    row++;
                    if (row % 2 == 0)
                    {
                        char[] signs = new char[] { '-', ',', '.', '!', '?' };
                        foreach (char sign in signs)
                        {
                            line = line.Replace(sign, '@');
                        }
                        string[] words = line.Split();
                        Console.WriteLine(string.Join(' ', words.Reverse()));
                    }
                }
            }
        }
    }
}
