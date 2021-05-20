using System;
using System.Collections.Generic;

namespace _4MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> myStack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    myStack.Push(i);
                }
                else if (input[i] == ')')
                {
                    int idx = myStack.Pop();
                    Console.WriteLine(input.Substring( idx, i - idx + 1));
                }
            }
        }
    }
}
