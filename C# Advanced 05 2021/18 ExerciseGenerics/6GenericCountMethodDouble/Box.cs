using System;

namespace GenericBoxOfString
{
    public class Box<T>
        where T : IComparable<T>
    {
        private T item;

        public Box(T item)
        {
            this.item = item;
        }

        public override string ToString()
        {
            return $"{item.GetType()}: {item}";
        }

        public bool isGreater(Box<T> target)
            
        {
            if (this.item.CompareTo(target.item) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
