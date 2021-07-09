using System.Collections.Generic;

namespace _8CollectionHierarchy
{
    public interface IAddCollection
    {
        List<string> Collection { get; set; }

        int Add(string strToAdd);
    }
}