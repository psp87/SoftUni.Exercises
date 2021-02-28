using System;
using System.Collections.Generic;
using System.IO;

namespace _05_LAB_SliceFile
{
    class Program
    {
        static void Main()
        {
            string sourceFile = @"05. Slice File\sliceMe.txt";

            int parts = 4;

            List<string> files = new List<string> { "Part-1.txt", "Part-2.txt", "Part-3.txt", "Part-4.txt" };

            using (var readFile = new FileStream(sourceFile, FileMode.Open))
            {
                long pieceSize = (long)Math.Ceiling((double)readFile.Length / parts);

                for (int i = 0; i < parts; i++)
                {
                    long currentPieceSize = 0;

                    using (var createFile = new FileStream(files[i], FileMode.Create))
                    {
                        byte[] buffer = new byte[4096];

                        while (readFile.Read(buffer, 0, buffer.Length) == buffer.Length)
                        {
                            currentPieceSize += buffer.Length;
                            createFile.Write(buffer, 0, buffer.Length);
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
