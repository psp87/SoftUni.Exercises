using System;
using System.IO;

namespace _01_OddLines
{
    class Program
    {
        static void Main()
        {
            using (var reader = new StreamReader(@"01. Odd Lines/Input.txt"))
            {
                int counter = 0;
                string line = reader.ReadLine();

                using (var writer = new StreamWriter("Output.txt"))
                {
                    while (line != null)
                    {
                        if (counter % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
