using System;

namespace _01SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int nMax = Math.Max(num1, Math.Max(num2, num3));
            int nMin = Math.Min(num1, Math.Min(num2, num3));

            Console.WriteLine(nMax);            
            Console.WriteLine((num1 + num2 + num3) - (nMax + nMin));
            Console.WriteLine(nMin);
        }
    }
}
