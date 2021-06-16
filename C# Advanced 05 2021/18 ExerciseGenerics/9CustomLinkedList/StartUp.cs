using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var myList = new DoublyLinkedList<int>();

            for (int i = 0; i < 5; i++)
            {
                myList.AddFirst(i);
                myList.AddLast(i);
            }
            myList.RemoveFirst();
            myList.RemoveLast();

            myList.ForEach(x => Console.WriteLine(x));

            var arrr = myList.ToArray();

            foreach (var number in arrr)
            {
                Console.Write(number);
            }
        }
    }
}
