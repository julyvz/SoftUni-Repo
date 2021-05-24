using System;
using System.Collections.Generic;

namespace _2StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<string> myStack = new Stack<string>(input.Split());

            string command = Console.ReadLine().ToUpper();
            while (command != "END")
            {
                string[] tokens = command.Split();
                if (tokens[0] == "ADD")
                {
                    myStack.Push(tokens[1]);
                    myStack.Push(tokens[2]);
                }
                else // REMOVE
                {
                    int n = int.Parse(tokens[1]);
                    if (n <= myStack.Count)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            myStack.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToUpper();
            }

            int sum = 0;
            foreach (var item in myStack)
            {
                sum += int.Parse(item);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}