using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04_LAB_MergeFiles
{
    class Program
    {
        static void Main()
        {
            List<string> words = new List<string>();

            using (var readerFile1 = new StreamReader(@"04. Merge Files\FileOne.txt"))
            {
                using (var readerFile2 = new StreamReader(@"04. Merge Files\FileTwo.txt"))
                {
                    using (var writer = new StreamWriter(@"Output.txt"))
                    {
                        string lineFileOne = readerFile1.ReadLine();
                        while (lineFileOne != null)
                        {
                            string[] wordsFileOne = lineFileOne.Split();

                            for (int i = 0; i < wordsFileOne.Length; i++)
                            {
                                words.Add(wordsFileOne[i]);
                            }

                            lineFileOne = readerFile1.ReadLine();
                        }

                        string lineFileTwo = readerFile2.ReadLine();
                        while (lineFileTwo != null)
                        {
                            string[] wordsFileTwo = lineFileTwo.Split();

                            for (int i = 0; i < wordsFileTwo.Length; i++)
                            {
                                words.Add(wordsFileTwo[i]);
                            }

                            lineFileTwo = readerFile2.ReadLine();
                        }
 
                        words = words.OrderBy(x => x).ToList();

                        foreach (var item in words)
                        {
                            writer.WriteLine(item);
                        }
                    }
                }
            }
        }
    }
}
