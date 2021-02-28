using System;
using System.Linq;

namespace _02_KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> print = x =>
            {
                foreach (var item in x)
                {
                    Console.WriteLine($"Sir {item}");
                }
            };

            print(names);
        }
    }
}
