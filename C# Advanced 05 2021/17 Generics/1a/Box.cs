using System;

namespace BoxOfT
{
    class Box<T>
    {
        private const int InitialCapacity = 4;
        private T[] items;

        public Box()
        {
            this.items = new T[InitialCapacity];
        }

        public int Count { get; private set; }

        private void Resize()
        {
            T[] copy = new T[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }

        public void Add(T element)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.items[this.Count] = element;
            this.Count++;
        }

        public T Remove()
        {
            var result = this.items[Count - 1];
            Count--;
            return result;
        }
    }
}
