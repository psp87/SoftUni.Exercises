using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Predicate<string> isLessThan = x => x.Length <= n;

            foreach (var name in names)
            {
                if (isLessThan(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
