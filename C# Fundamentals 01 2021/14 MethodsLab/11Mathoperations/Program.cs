using System;

namespace _11Mathoperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            char oper = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(n1, oper, n2));
        }

        static double Calculate(double n1, char oper, double n2)
        {
            double result = 0;

            switch (oper)
            {
                case '/':
                    result = n1 / n2;
                    break;
                case '*':
                    result = n1 * n2;
                    break;
                case '+':
                    result = n1 + n2;
                    break;
                case '-':
                    result = n1 - n2;
                    break;
            }
            return result;
        }
    }
}
