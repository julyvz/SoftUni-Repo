using System;
using System.Collections.Generic;
using System.Text;

namespace _8CollectionHierarchy
{
    public class MyList : IMyList
    {
        public List<string> Collection { get; set; }
        public int Used => Collection.Count;

        public MyList()
        {
            Collection = new List<string>();
        }

        public int Add(string strToAdd)
        {
            Collection.Insert(0, strToAdd);
            return 0;
        }

        public string Remove()
        {
            string removed = Collection[0];
            Collection.RemoveAt(0);
            return removed;
        }

    }
}
