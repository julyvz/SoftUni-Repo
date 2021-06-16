using System;
using System.Collections.Generic;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Box<string>> myList = new List<GenericBoxOfString.Box<string>>();

            for (int i = 0; i < n; i++)
            {
                Box<string> currentBox = new Box<string>(Console.ReadLine());
                myList.Add(currentBox);
            }

            string[] tokens = Console.ReadLine().Split();
            int idx1 = int.Parse(tokens[0]);
            int idx2 = int.Parse(tokens[1]);

            Swap(myList, idx1, idx2);
        }

        private static void Swap<T>(List<T> myList, int idx1, int idx2)
        {
            T temp = myList[idx1];
            myList[idx1] = myList[idx2];
            myList[idx2] = temp;

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
