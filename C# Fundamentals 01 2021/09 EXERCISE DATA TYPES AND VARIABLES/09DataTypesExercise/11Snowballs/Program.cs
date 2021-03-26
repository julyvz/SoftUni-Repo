using System;
using System.Numerics;

namespace _11Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int snowballSnow = 0, snowballTime = 0, snowballQuality = 0;
            int maxSnow = 0, maxTime = 0, maxQuality = 0;
            BigInteger maxValue = 0;
            BigInteger snowballValue = 0;
            for (int i = 0; i < n; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > maxValue)
                {
                    maxValue = snowballValue;
                    maxSnow = snowballSnow;
                    maxTime = snowballTime;
                    maxQuality = snowballQuality;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue} ({maxQuality})");
        }
    }
}
