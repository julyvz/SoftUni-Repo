using System;

namespace _09SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int yield = 0;
            int days = 0;
            while (n >= 100)
            {
                days++;
                yield += n;
                n -= 10;
                yield -= 26;
            }
            if (days >= 1)
            {
            yield -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(yield);
        }
    }
}
