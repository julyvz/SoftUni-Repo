using System;
using System.Collections.Generic;

namespace _8TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int totalCarsPassed = 0;
            string car = Console.ReadLine();

            while (car != "end")
            {
                if (car != "green")
                {
                    cars.Enqueue(car);
                }
                else
                {
                    int min = n < cars.Count ? n : cars.Count;
                    for (int i = 0; i < min; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        totalCarsPassed++;
                    }
                }

                car = Console.ReadLine();
            }

            Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
        }
    }
}
