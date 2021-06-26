using System;
using System.Linq;

namespace _5MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();


        }
    }

    public class MergeSort<T> where T : IComparable
    {
        private static T[] aux;

        public static void Sort(T[] arr)
        {
            

        }

        private static void Merge(T[] arr, int low, int mid, int hi)

    }
}
