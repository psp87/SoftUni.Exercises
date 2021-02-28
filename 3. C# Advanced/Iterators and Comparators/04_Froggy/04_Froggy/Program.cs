using System;
using System.Linq;

namespace _04_Froggy
{
    class Program
    {
        static void Main()
        {
            int[] stoneValues = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(stoneValues);

            Console.WriteLine(String.Join(", ", lake));
        }
    }
}
