using System;
using System.Linq;

namespace _01_ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ");

            Action<string[]> print = x => Console.WriteLine(String.Join("\n", x));

            print(names);
        }
    }
}
