using System.Collections.Generic;

namespace _8CollectionHierarchy
{
    public class AddRemoveCollection : IAddRemoveCollection
    {
        public List<string> Collection { get; set; }

        public AddRemoveCollection()
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
            string removed = Collection[^1];
            Collection.RemoveAt(Collection.Count - 1);
            return removed;
        }
    }
}
