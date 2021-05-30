using System;
using System.IO;

namespace _5SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // •	Part-1.txt
            int parts = 4;

            using (var reader = new FileStream("sliceMe.txt", FileMode.Open))
            {
                long pieceSize = (long)Math.Ceiling((double)reader.Length / parts);
                for (int i = 1; i <= parts; i++)
                {
                    long currentPieceSize = 0;

                    using (var streamCreateFile = new FileStream($"Part-{i}.txt", FileMode.Create))
                    {
                        byte[] buffer = new byte[4096];
                        while ((reader.Read(buffer, 0, buffer.Length)) == buffer.Length)
                        {
                            currentPieceSize += buffer.Length;
                            streamCreateFile.Write(buffer, 0, buffer.Length);
                            if (currentPieceSize >= pieceSize)
                            {
                                break;
                            }
                        }
                    }

                }
            }
        }
    }
}
