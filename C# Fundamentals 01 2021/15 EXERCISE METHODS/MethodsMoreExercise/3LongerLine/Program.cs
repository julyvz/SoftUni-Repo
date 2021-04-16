using System;

namespace _3LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            if (Length(x1, y1, x2, y2) >= Length(x3, y3, x4, y4))
            {
                if (DistFromCenter(x1, y1) <= DistFromCenter(x2, y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (DistFromCenter(x3, y3) <= DistFromCenter(x4, y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        private static double Length(double x1, double y1, double x2, double y2)
        {
            double deltaX = Math.Abs(x1 - x2);
            double deltaY = Math.Abs(y1 - y2);
            return (deltaX * deltaX + deltaY * deltaY);
        }

        private static double DistFromCenter(double x, double y)
        {
            return (x * x + y * y);
        }
    }
}
