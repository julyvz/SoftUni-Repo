using System;
using System.Collections.Generic;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Box<double>> myList = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                Box<double> currentBox = new Box<double>(double.Parse(Console.ReadLine()));
                myList.Add(currentBox);
            }

            Box<double> target = new Box<double>(double.Parse(Console.ReadLine()));

            int greatest = CountTheGreatest(myList, target);
            Console.WriteLine(greatest);
        }

        private static int CountTheGreatest(List<Box<double>> myList, Box<double> target)
        {
            int count = 0;
            foreach (var item in myList)
            {
                if (item.isGreater(target))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
