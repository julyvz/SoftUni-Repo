using System;

namespace _7WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int capacity = 255;
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                int addition = int.Parse(Console.ReadLine());
                if (addition <= capacity)
                {
                    capacity -= addition;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(255 - capacity);
        }
    }
}
