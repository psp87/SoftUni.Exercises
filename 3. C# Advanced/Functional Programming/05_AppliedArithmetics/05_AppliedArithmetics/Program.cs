using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_AppliedArithmetics
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<List<int>, List<int>> add = x => x.Select(y => ++y).ToList();
            Func<List<int>, List<int>> subtract = x => x.Select(y => --y).ToList();
            Func<List<int>, List<int>> multiply = x => x.Select(y => y *= 2).ToList();
            Action<List<int>> print = x => Console.WriteLine(String.Join(" ", x));

            string command = Console.ReadLine();

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = add(numbers);
                        break;
                    case "subtract":
                        numbers = subtract(numbers);
                        break;
                    case "multiply":
                        numbers = multiply(numbers);
                        break;
                    case "print": print(numbers); break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
