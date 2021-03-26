using System;

namespace _10PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int pokes = 0;
            int nOriginal = n;
            while (n >= m)
            {
                n -= m;
                pokes++;                
                if (n == nOriginal / 2 && y != 0)
                {
                        n = n / y;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(pokes);
        }
    }
}
