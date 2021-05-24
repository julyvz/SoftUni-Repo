using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> myStack = new Stack<char>();
            foreach (var sign in input)
            {
                myStack.Push(sign);
            }

            while (myStack.Count > 0)
            {
            Console.Write(myStack.Pop());
            }
        }
    }
}
