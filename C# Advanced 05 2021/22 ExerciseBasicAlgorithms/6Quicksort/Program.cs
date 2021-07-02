using System;
using System.Linq;

namespace _6Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            arr = Sort<int>(arr);
            Console.WriteLine(string.Join(' ', arr));
        }

        public static T[] Sort<T>(T[] a) where T : IComparable<T>
        {
            Sort(a, 0, a.Length - 1);
            return a;
        }

        private static void Sort<T>(T[] a, int lo, int hi) where T : IComparable<T>
        {
            if (lo >= hi)
            {
                return;
            }

            int p = Partition(a, lo, hi);
            Sort(a, lo, p - 1);
            Sort(a, p + 1, hi);
        }

        private static int Partition<T>(T[] a, int lo, int hi) where T : IComparable<T>
        {
            
        }
    }
}
