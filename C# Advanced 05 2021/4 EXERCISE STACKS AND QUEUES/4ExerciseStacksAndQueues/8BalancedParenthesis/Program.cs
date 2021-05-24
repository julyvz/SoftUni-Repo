using System;
using System.Collections.Generic;

namespace _8BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> parentheses = new Stack<char>();
            bool isBalanced = true;            

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '(' || input[i] == '[')
                {
                    parentheses.Push(input[i]);
                }
                else
                {
                    if (parentheses.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }
                    switch (input[i])
                    {
                        case ')':
                            if (parentheses.Peek() == '(')
                            {
                                parentheses.Pop();
                            }
                            else
                            {
                                isBalanced = false;
                            }
                            break;
                        case '}':
                            if (parentheses.Peek() == '{')
                            {
                                parentheses.Pop();
                            }
                            else
                            {
                                isBalanced = false;
                            }
                            break;
                        case ']':
                            if (parentheses.Peek() == '[')
                            {
                                parentheses.Pop();
                            }
                            else
                            {
                                isBalanced = false;
                            }
                            break;
                    }
                }
            }

            Console.WriteLine(isBalanced ? "YES" : "NO");
        }
    }
}
