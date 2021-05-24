using System;
using System.Collections.Generic;

namespace _9SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = "";
            Stack<string> undo = new Stack<string>();

            for (int i = 0; i < n; i++)
            {                
                string command = Console.ReadLine();
                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "1":
                        undo.Push(text);
                        string someText = command.Substring(2);
                        text += someText;
                        break;
                    case "2":
                        undo.Push(text);
                        int len = text.Length - int.Parse(tokens[1]);
                        text = text.Substring(0, len);
                        break;
                    case "3":
                        Console.WriteLine(text[int.Parse(tokens[1]) - 1]);
                        break;
                    case "4":
                        text = undo.Pop();
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }
    }
}
