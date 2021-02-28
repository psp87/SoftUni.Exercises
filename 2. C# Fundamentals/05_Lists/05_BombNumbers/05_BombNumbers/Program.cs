using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<string> specials = Console.ReadLine().Split(" ").ToList();

            int specialNumber = int.Parse(specials[0]);
            int power = int.Parse(specials[1]);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNumber)
                {
                    int startIndex = Math.Max(i - power, 0);
                    int endIndex = Math.Min(i + power, numbers.Count - 1);
                    int length = endIndex - startIndex + 1;
                    numbers.RemoveRange(startIndex, length);
                    i = 0;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
