using System;

namespace _8MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            double result = MathPower(n, e);
            Console.WriteLine(result);
        }

        static double MathPower(double n, int e)
        {
            double result = 1;
            for (int i = 0; i < e; i++)
            {
                result *= n;
            }
            return result;
        }
    }
}
