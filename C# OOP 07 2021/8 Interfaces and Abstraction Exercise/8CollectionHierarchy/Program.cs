using System;

namespace _8CollectionHierarchy
{
   public class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            foreach (var str in inputStrings)
            {
                Console.Write(addCollection.Add(str) + " ");
            }
            Console.WriteLine();

            foreach (var str in inputStrings)
            {
                Console.Write(addRemoveCollection.Add(str) + " ");
            }
            Console.WriteLine();

            foreach (var str in inputStrings)
            {
                Console.Write(myList.Add(str) + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write(addRemoveCollection.Remove() + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write(myList.Remove() + " ");
            }
            Console.WriteLine();
        }
    }
}
