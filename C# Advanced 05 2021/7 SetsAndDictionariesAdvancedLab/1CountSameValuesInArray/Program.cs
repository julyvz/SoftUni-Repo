﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _1CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> output = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!output.ContainsKey(input[i]))
                {
                    output.Add(input[i], 0);
                }
                output[input[i]]++;
            }

            foreach (var number in output)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
