using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listSplitted = Console.ReadLine().Split("|").ToList();
            var finalList = new List<string>();

            for (int i = listSplitted.Count - 1; i >= 0; i--)
            {
                List<string> numbersSplited = listSplitted[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (string value in numbersSplited)
                {
                    finalList.Add(value);
                }
            }
            Console.WriteLine(String.Join(" ", finalList));
        }
    }
}
