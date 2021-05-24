using System;
using System.Collections.Generic;

namespace _7TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int> fuel = new Queue<int>();
            Queue<int> distance = new Queue<int>();

            int startPoint = -1;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                fuel.Enqueue(int.Parse(input[0]));
                distance.Enqueue(int.Parse(input[1]));
            }

            bool success = false;

            while (!success)
            {
                int currentFuel = 0;
                int currentDistance = 0;
                success = true;

                for (int i = 0; i < n; i++)
                {
                    currentFuel += fuel.Peek();
                    currentDistance += distance.Peek();
                    if (currentFuel < currentDistance)
                    {
                        success = false;                        
                    }
                    else
                    {
                        currentFuel -= currentDistance;
                        currentDistance = 0;
                    }
                    fuel.Enqueue(fuel.Dequeue());
                    distance.Enqueue(distance.Dequeue());
                }

                startPoint++;
                fuel.Enqueue(fuel.Dequeue());
                distance.Enqueue(distance.Dequeue());
            }

            Console.WriteLine(startPoint);
        }
    }
}
