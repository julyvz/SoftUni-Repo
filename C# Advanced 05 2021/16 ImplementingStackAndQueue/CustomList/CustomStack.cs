using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class CustomStack
    {
        private const int initialCapacity = 4;
        private int[] items;

        public CustomStack()
        {
            this.Count = 0;
            this.items = new int[initialCapacity];
        }

        public int Count { get; private set; }

        public void Push(int element)
        {
            if (items.Length == Count)
            {
                var nextItems = new int[items.Length * 2];
                for (int i = 0; i < Count; i++)
                {
                    nextItems[i] = items[i];
                }
                items = nextItems;
            }            
            
            items[Count] = element;
            Count++;
        }

        public int Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }
            
            int result = items[Count - 1];
            Count--;
            return result;
        }

        public int Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            int result = items[Count - 1];
            return result;
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(items[i]);
            }
        }
    }
}
