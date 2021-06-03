using System;
using System.IO;

namespace _5a
{
    class Program
    {
        static void Main(string[] args)
        {
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

                        int bytes = -1;
                        while (currentPieceSize < pieceSize && bytes != 0)
                        {
                            int bytesToRead = Math.Min(buffer.Length, (int)(pieceSize - currentPieceSize));
                            bytes = reader.Read(buffer, 0, bytesToRead);
                            streamCreateFile.Write(buffer, 0, bytes);
                            currentPieceSize += bytes;
                        }
                    }
                }
            }
        }
    }
}
