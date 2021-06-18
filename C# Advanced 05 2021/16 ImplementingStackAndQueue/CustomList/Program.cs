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
            myList.Add(35);
           
            Console.WriteLine(myList.RemoveAt(2));
            myList.InsertAt(1, 40);
            myList.InsertAt(3, 30);

            Console.WriteLine(myList.Contains(30));
            Console.WriteLine(myList.Contains(120));

            myList.Swap(0, 3);

            CustomStack myStack = new CustomStack();

            myStack.Push(5);
            myStack.Push(4);
            myStack.Push(3);
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Pop());

        }
    }
}
