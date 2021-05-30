using System;
using System.IO;

namespace _6FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileNames = Directory.GetFiles(@"D:\SoftUni\SoftUni Repo\C# Advanced 05 2021\9StreamsFilesAndDirectoriesLab\6FolderSize\TestFolder\");
            double totalSize = 0;

            foreach (var file in fileNames)
            {
                FileInfo info = new FileInfo(file);
                totalSize += info.Length;
            }

            totalSize = totalSize / 1024 / 1024;

            File.WriteAllText("Output.txt", totalSize.ToString());
        }
    }
}
