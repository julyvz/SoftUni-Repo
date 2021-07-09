using System.Collections.Generic;

namespace _8CollectionHierarchy
{
    public interface IAddRemoveCollection
    {
        List<string> Collection { get; set; }

        int Add(string strToAdd);
        string Remove();
    }
}