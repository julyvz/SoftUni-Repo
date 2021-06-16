using System;
using System.Collections.Generic;
using System.Text;

namespace _7Tuple
{
    class Threeuple<T, V, W>
    {
        private T item1;
        private V item2;
        private W item3;

        public Threeuple(T item1, V item2, W item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public override string ToString()
        {
            return $"{item1} -> {item2} -> {item3}";
        }
    }
}
