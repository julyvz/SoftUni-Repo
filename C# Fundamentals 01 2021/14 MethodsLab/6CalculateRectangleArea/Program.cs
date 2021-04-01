using System;

namespace _6CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double S = CalculateRectangleArea(num1, num2);
            Console.WriteLine(S);
        }

        static double CalculateRectangleArea(double l, double w)
        {
            double S = l * w;
            return S;
        }
    }
}
