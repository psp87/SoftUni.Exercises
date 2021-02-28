using System;
using System.IO;

namespace _02_LAB_LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"02. Line Numbers\Input.txt");

            using (reader)
            {
                int counter = 1;
                string line = reader.ReadLine();

                using (var writer = new StreamWriter("Output.txt"))
                {
                    while (line != null)
                    {
                        writer.WriteLine($"{counter}. {line}");

                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
