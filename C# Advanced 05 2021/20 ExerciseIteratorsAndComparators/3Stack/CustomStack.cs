using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _3Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private const int InitialSize = 4;
        private T[] arr;

        public CustomStack()
        {
            Count = 0;
            arr = new T[InitialSize];
        }

        public int Count { get; private set; }

        public void Push(T element)
        {
            if (arr.Length == Count)
            {
                var nextItems = new T[arr.Length * 2];
                for (int i = 0; i < Count; i++)
                {
                    nextItems[i] = arr[i];
                }
                arr = nextItems;
            }
            arr[Count] = element;
            Count++;
        }

        public void Pop()
        {
            if (Count == 0)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                Count--;
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
