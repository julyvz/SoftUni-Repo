using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class CustomList
    {
        private const int initialCapacity = 2;
        private int[] items;

        public CustomList()
        {
            this.items = new int[initialCapacity];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index >= this.Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Index out of range.");
                }
                return items[index];
            }
            set
            {
                if (index >= this.Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Index out of range.");
                }
                items[index] = value;
            }
        }

        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }

        public void Add(int element)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.items[this.Count] = element;
            this.Count++;
        }

        public int RemoveAt(int index)
        {
            if (index >= this.Count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }

            var item = this.items[index];
            this.items[index] = default(int);
            this.Shift(index);
            this.Count--;
            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }

            return item;
        }

        public void InsertAt(int index, int element)
        {
            if (index > this.Count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.ShiftToRight(index);
            this.items[index] = element;
            Count++;
        }

        public bool Contains(int element)
        {
            bool contains = false;
            for (int i = 0; i < this.Count; i++)
            {
                if (items[i] == element)
                {
                    contains = true;
                    break;
                }
            }

            return contains;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex > this.Count || firstIndex < 0)
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }
            if (secondIndex > this.Count || secondIndex < 0)
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }
            var temp = this.items[firstIndex];
            this.items[firstIndex] = this.items[secondIndex];
            this.items[secondIndex] = temp;
        }

        private void Shift (int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }

        private void ShiftToRight(int index)
        {
            for (int i = Count; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }
        }

        private void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
    }
}
