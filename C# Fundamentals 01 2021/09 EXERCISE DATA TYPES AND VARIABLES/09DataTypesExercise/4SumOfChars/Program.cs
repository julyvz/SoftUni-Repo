﻿using System;

namespace _4SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char a = char.Parse(Console.ReadLine());
                sum += a;
            }
            
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
