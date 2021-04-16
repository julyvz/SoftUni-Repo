using System;

namespace _5AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int sum = Sum(n1, n2);
            int result = Subtract(sum, n3);
            Console.WriteLine(result);
        }

        private static int Subtract(int sum, int n3)
        {
            return (sum - n3);
        }

        private static int Sum(int n1, int n2)
        {
            return (n1 + n2);
        }
    }
}
