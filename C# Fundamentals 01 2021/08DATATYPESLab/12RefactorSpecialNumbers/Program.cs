using System;

namespace _12RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNum;
            for (int digit = 1; digit <= n; digit++)
            {
                int sum = 0;
                bool isSpecial = false;
                currentNum = digit;
                while (currentNum > 0)
                {
                    sum += currentNum % 10;
                    currentNum = currentNum / 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }
                Console.WriteLine("{0} -> {1}", digit, isSpecial);
            }
        }
    }
}
