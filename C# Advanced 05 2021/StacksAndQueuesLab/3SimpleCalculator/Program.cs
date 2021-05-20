using System;
using System.Collections.Generic;

namespace _3SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] nums = input.Split();
            Array.Reverse(nums);

            Stack<string> myStack = new Stack<string>(nums);

            while (myStack.Count > 1)
            {
                int a = int.Parse(myStack.Pop());
                string sign = myStack.Pop();
                int b = int.Parse(myStack.Pop());
                if (sign == "+")
                {
                    myStack.Push((a + b).ToString());
                }
                else
                {
                    myStack.Push((a - b).ToString());
                }
            }

            Console.WriteLine(myStack.Pop());
        }
    }
}
