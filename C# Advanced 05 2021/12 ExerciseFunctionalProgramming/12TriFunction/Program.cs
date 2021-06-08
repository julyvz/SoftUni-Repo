using System;

namespace _12TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split();

            Func<string, int> sumOfCharacters = name =>
            {
                int sum = 0;
                foreach (var letter in name)
                {
                    sum += letter;
                }
                return sum;
            };

            Func<int, int, bool> isLarger = (sumOfChar, n) =>
            {
                if (sumOfChar >= n)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            foreach (var name in names)
            {
                if (isLarger(sumOfCharacters(name), n))
                {
                    Console.WriteLine(name);
                    return;
                }
            }
        }
    }
}
