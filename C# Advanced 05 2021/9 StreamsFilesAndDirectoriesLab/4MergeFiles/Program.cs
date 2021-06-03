using System;
using System.Collections.Generic;
using System.IO;

namespace _4MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> file1 = new List<string>();
            using (var reader1 = new StreamReader("FileOne.txt"))
            {
                string line1 = "";
                while ((line1 = reader1.ReadLine()) != null)
                {
                    file1.Add(line1);
                }
            }

            List<string> file2 = new List<string>();
            using (var reader2 = new StreamReader("FileTwo.txt"))
            {
                string line2 = "";
                while ((line2 = reader2.ReadLine()) != null)
                {
                    file2.Add(line2);
                }
            }

            using (var writer = new StreamWriter("Output.txt"))
            {
                int smaller = Math.Min(file1.Count, file2.Count);
                for (int i = 0; i < smaller; i++)
                {
                    writer.WriteLine(file1[i]);
                    writer.WriteLine(file2[i]);
                }
                if (file1.Count > file2.Count)
                {
                    for (int i = smaller; i < file1.Count; i++)
                    {
                        writer.WriteLine(file1[i]);
                    }
                }
                else if (file2.Count > file1.Count)
                {
                    for (int i = smaller; i < file2.Count; i++)
                    {
                        writer.WriteLine(file2[i]);
                    }
                }
            }
        }
    }
}
