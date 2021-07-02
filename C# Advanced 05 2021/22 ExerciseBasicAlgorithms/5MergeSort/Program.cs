using System;
using System.Linq;

namespace _5MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            arr = MergeSort<int>.Sort(arr);
            Console.WriteLine(string.Join(' ', arr));
        }
    }

    public class MergeSort<T> where T : IComparable
    {
        public static T[] Sort(T[] arr)
        {
            if (arr.Length <= 1)
            {
                return arr;
            }
             
            var mid = arr.Length / 2;
            T[] leftArr = new T[mid];
            T[] rightArr = new T[arr.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                leftArr[i] = arr[i];
            }
            for (int i = mid, j = 0; i < arr.Length; i++, j++)
            {
                rightArr[j] = arr[i];
            }

            leftArr = Sort(leftArr);
            rightArr = Sort(rightArr);

            return Merge(leftArr, rightArr);
        }

        private static T[] Merge(T[] left, T[] right)
        {
            int leftIncrease = 0;
            int rightIncrease = 0;
            T[] arr = new T[left.Length + right.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (rightIncrease == right.Length || ((leftIncrease < left.Length) && (left[leftIncrease].CompareTo(right[rightIncrease]) <= 0)))
                {
                    arr[i] = left[leftIncrease];
                    leftIncrease++;
                }
                else if (leftIncrease == left.Length || ((rightIncrease < right.Length) && (left[leftIncrease].CompareTo(right[rightIncrease]) > 0)))
                {
                    arr[i] = right[rightIncrease];
                    rightIncrease++;
                }
            }
            return arr;
        }
    }
}
