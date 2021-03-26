﻿using System;

namespace _8BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double maxVolume = 0;
            string maxKeg = "";
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    maxKeg = model;
                }
            }
            Console.WriteLine(maxKeg);
        }
    }
}
