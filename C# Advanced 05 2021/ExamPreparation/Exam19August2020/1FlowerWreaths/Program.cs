using System;
using System.Collections.Generic;
using System.Linq;

namespace _1FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));

            int wreaths = 0;
            int forLater = 0;

            while (lilies.Count > 0 && roses.Count > 0)
            {
                int currLily = lilies.Peek();
                int currRose = roses.Peek();
                int sum = currLily + currRose;

                if (sum == 15)
                {
                    wreaths++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (sum > 15)
                {
                    while (sum > 15)
                    {
                        sum -= 2;

                        if (sum == 15)
                        {
                            wreaths++;
                        }
                        else if (sum < 15)
                        {
                            forLater += sum;
                        }
                    }
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (sum < 15)
                {
                    forLater += sum;
                    lilies.Pop();
                    roses.Dequeue();
                }
            }

            wreaths += forLater / 15;

            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
        }
    }
}
