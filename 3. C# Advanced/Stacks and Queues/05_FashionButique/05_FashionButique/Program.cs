using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_FashionButique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> someInt = new Stack<int>(input);

            int capacity = int.Parse(Console.ReadLine());

            int finalBoxes = 1;

            int currentCapacity = capacity;

            for (int i = input.Length-1; i >= 0; i--)
            {
                int currentNumber = input[i];

                if (currentNumber <= currentCapacity)
                {
                    currentCapacity -= someInt.Pop();
                }

                else
                {
                    finalBoxes++;
                    currentCapacity = capacity;
                    currentCapacity -= someInt.Pop();
                }
            }

            Console.WriteLine(finalBoxes);
        }
    }
}
