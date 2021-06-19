using System;

namespace _3Stack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input;
            CustomStack<string> myStack = new CustomStack<string>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "Push")
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        string element = tokens[i].Split(',', StringSplitOptions.RemoveEmptyEntries)[0];
                        myStack.Push(element);
                    }
                }
                else
                {
                    myStack.Pop();
                }
            }
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
