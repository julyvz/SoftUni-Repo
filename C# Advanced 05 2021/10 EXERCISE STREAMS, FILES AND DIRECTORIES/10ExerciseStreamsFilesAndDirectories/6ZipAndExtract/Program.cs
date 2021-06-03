using System;
using System.IO.Compression;

namespace _6ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDirectory = @"D:\SoftUni\SoftUni Repo\C# Advanced 05 2021\10 EXERCISE STREAMS, FILES AND DIRECTORIES";
            string targetDirectory = @"D:\SoftUni\Temp";
            ZipFile.CreateFromDirectory(sourceDirectory, @"D:\SoftUni\Temp\report.zip");
            ZipFile.ExtractToDirectory(@"D:\SoftUni\Temp\report.zip", targetDirectory);
        }
    }
}
