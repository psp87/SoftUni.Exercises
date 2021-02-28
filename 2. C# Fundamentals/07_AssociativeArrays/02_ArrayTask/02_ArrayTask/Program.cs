using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_ArrayTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int lineCount = 0;
            string str = string.Empty;

            string input = Console.ReadLine();

            while (input != "stop")
            {
                if (lineCount % 2 == 0)
                {
                    str = input;
                }

                else
                {
                    int number = int.Parse(input);
                    if (dict.ContainsKey(str))
                    {
                        dict[str] += number;
                    }
                    else
                    {
                        dict.Add(str, number);
                    }
                }

                lineCount++;
                input = Console.ReadLine();
            }

            foreach (var i in dict)
            {
                Console.WriteLine($"{i.Key} -> {i.Value}");
            }
        }
    }
}
