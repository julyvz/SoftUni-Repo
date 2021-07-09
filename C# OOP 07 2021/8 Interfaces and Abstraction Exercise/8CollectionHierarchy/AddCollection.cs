using System.Collections.Generic;

namespace _8CollectionHierarchy
{
    public class AddCollection : IAddCollection
    {

        public List<string> Collection { get; set; }

        public AddCollection()
        {
            Collection = new List<string>();
        }

        public int Add(string strToAdd)
        {
            Collection.Add(strToAdd);
            return Collection.Count - 1;
        }
    }
}
