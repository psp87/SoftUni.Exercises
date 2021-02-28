using System;
using System.Linq;

namespace _04_FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int lower = bounds[0];
            int upper = bounds[1];

            string command = Console.ReadLine();

            Predicate<int> filter = x => command == "even" ? x % 2 == 0 : x % 2 != 0;

            for (int i = lower; i <= upper; i++)
            {
                if (filter(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
