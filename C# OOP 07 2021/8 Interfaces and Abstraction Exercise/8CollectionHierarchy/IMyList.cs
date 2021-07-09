using System.Collections.Generic;

namespace _8CollectionHierarchy
{
    public interface IMyList
    {
        List<string> Collection { get; set; }
        int Used { get; }

        int Add(string strToAdd);
        string Remove();
    }
}