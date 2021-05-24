using System;
using System.Collections.Generic;

namespace _10Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenTime = int.Parse(Console.ReadLine());
            int free = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();
            int totalCarsPassed = 0;

            string car = Console.ReadLine();

            while (car != "END")
            {
                if (car == "green")
                {
                    int remainingTime = greenTime;
                    string currentCar = "";
                    while (remainingTime > 0 && queue.Count > 0)
                    {
                        currentCar = queue.Dequeue();
                        totalCarsPassed++;
                        remainingTime -= currentCar.Length;
                    }
                    remainingTime += free;
                    if (remainingTime < 0)
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{currentCar} was hit at {currentCar[currentCar.Length + remainingTime]}.");
                        return;
                    }
                }
                else
                {
                    queue.Enqueue(car);
                }

                car = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
        }
    }
}
