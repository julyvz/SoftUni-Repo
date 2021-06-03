using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("text.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                int letters = 0;
                int marks = 0;
                foreach (char symbol in lines[i])
                {
                    if (char.IsPunctuation(symbol))
                    {
                        marks++;
                    }
                    else if(char.IsLetter(symbol))
                    {
                        letters++;
                    }
                }

                lines[i] = ($"Line {i + 1}:{lines[i]}({letters})({marks})");
            }
                File.WriteAllLines("output.txt", lines);
        }
    }
}
