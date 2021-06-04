using System;
using System.Linq;

namespace _3CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> selectSmallest = x =>
            {
                int minNumber = int.MaxValue;
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] < minNumber)
                    {
                        minNumber = x[i];
                    }
                }
                return minNumber;
            };

            Console.WriteLine(selectSmallest(numbers));
        }
    }
}
