using System;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList myList = new CustomList();

            myList.Add(45);
            myList.Add(25);
            myList.Add(15);
            
            Console.WriteLine(myList.RemoveAt(1));
            myList.InsertAt(1, 40);
            myList.InsertAt(3, 30);

            Console.WriteLine(myList.Contains(30));
            Console.WriteLine(myList.Contains(120));

            myList.Swap(0, 3);
        }
    }
}
