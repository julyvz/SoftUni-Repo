using System;
using System.Collections.Generic;

namespace _4FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] boundaries = Console.ReadLine().Split();
            int min = int.Parse(boundaries[0]);
            int max = int.Parse(boundaries[1]);

            string condition = Console.ReadLine();

            Predicate<int> meetTheCondition = CheckTheCondition(condition);

            List<int> output = new List<int>();
            for (int i = min; i <= max; i++)
            {
                if (meetTheCondition(i))
                {
                    output.Add(i);
                }
            }
            Console.WriteLine(string.Join(' ', output));
        }

        private static Predicate<int> CheckTheCondition(string condition)
        {
            switch (condition)
            {
                case "odd": return x => x % 2 != 0;
                case "even": return x => x % 2 == 0;
                default: return null;
            }
        }
    }
}
