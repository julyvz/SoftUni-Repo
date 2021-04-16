using System;

namespace _5MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            double[] arr = new double[n];
            bool hasZero = false;
            int countOfNegative = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
                if (arr[i] == 0)
                {
                    hasZero = true;
                }
                else if (arr[i] < 0)
                {
                    countOfNegative++;
                }
            }

            if (hasZero)
            {
                Console.WriteLine("zero");
            }
            else
            {
                if (countOfNegative % 2 == 0)
                {
                    Console.WriteLine("positive");
                }
                else
                {
                    Console.WriteLine("negative");
                }
            }
        }
    }
}
