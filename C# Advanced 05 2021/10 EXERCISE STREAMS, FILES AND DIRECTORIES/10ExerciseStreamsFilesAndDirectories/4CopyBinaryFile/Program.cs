using System;
using System.IO;

namespace _4CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new FileStream("copyMe.png", FileMode.Open))
            {
                using (var writer = new FileStream("newfile.png", FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    int readBytes = 0;
                    while ((readBytes = reader.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        writer.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
