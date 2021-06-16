using System;
using System.Collections.Generic;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Box<string>> myList = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                Box<string> currentBox = new Box<string>(Console.ReadLine());
                myList.Add(currentBox);
            }

            Box<string> target = new Box<string>(Console.ReadLine());

            int greatest = CountTheGreatest(myList, target);
            Console.WriteLine(greatest);
        }

        private static int CountTheGreatest(List<Box<string>> myList, Box<string> target)
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
