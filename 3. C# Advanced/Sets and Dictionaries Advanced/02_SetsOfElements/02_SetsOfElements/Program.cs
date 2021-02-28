using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sizeOne = sizes[0];
            int sizeTwo = sizes[1];

            HashSet<int> numbersOne = new HashSet<int>();
            HashSet<int> numbersTwo = new HashSet<int>();
            HashSet<int> repeated = new HashSet<int>();

            for (int i = 0; i < sizeOne + sizeTwo; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i < sizeOne)
                {
                    numbersOne.Add(number);
                }
                else
                {
                    numbersTwo.Add(number);
                }
            }

            foreach (var number in numbersOne)
            {
                if (numbersTwo.Contains(number))
                {
                    repeated.Add(number);
                }
            }

            Console.WriteLine(String.Join(" ", repeated));
        }
    }
}
