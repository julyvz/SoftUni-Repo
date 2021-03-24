using System;

namespace _06StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberAsText = Console.ReadLine();
            int num = int.Parse(numberAsText);

            int digits = numberAsText.Length;
            int factorialSum = 0;

            for (int i = 0; i < digits; i++)
            {
                int digitI = int.Parse(numberAsText[i].ToString());
                int factI = 1;
                for (int j = 1; j <= digitI; j++)
                {
                    factI *= j; 
                }
                factorialSum += factI;
            }

            if (factorialSum == num )
            {
                Console.WriteLine("yes");
            }
            else
            {
            Console.WriteLine("no");
            }
        }
    }
}
