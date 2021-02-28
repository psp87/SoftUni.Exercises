using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_PeriodicTable
{
    class Program
    {
        public static object Hashset { get; private set; }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> elements = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in input)
                {
                    elements.Add(element);
                }
            }

            Console.WriteLine(String.Join(" ", elements.OrderBy(x => x)));
        }
    }
}
