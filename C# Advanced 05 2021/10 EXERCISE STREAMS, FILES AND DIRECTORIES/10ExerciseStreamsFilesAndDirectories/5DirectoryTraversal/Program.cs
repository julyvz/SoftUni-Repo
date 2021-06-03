using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _5DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
            Dictionary<string, Dictionary<string, double>> filesByExtension = new Dictionary<string, Dictionary<string, double>>();

            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                string fileName = info.Name;
                string fileExtension = info.Extension;
                double fileSize = info.Length * 1.0 / 1024;

                if (!filesByExtension.ContainsKey(fileExtension))
                {
                    filesByExtension.Add(fileExtension, new Dictionary<string, double>());
                }
                filesByExtension[fileExtension].Add(fileName, fileSize);
            }

            using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt"))
            {
                foreach (var extension in filesByExtension.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    writer.WriteLine(extension.Key);
                    foreach (var kvp in extension.Value.OrderBy(x => x.Value))
                    {
                        writer.WriteLine($"--{kvp.Key} - {kvp.Value:F3}kb");
                    }
                }
            }
        }
    }
}
