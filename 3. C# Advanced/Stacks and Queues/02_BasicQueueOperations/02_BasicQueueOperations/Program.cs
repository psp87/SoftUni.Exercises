using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_BasicStackOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayCommands = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = arrayCommands[0];
            int s = arrayCommands[1];
            int x = arrayCommands[2];

            string[] numbers = Console.ReadLine().Split();

            Queue<string> someQueue = new Queue<string>(numbers);

            for (int i = 0; i < s; i++)
            {
                someQueue.Dequeue();
            }

            if (someQueue.Any())
            {
                if (someQueue.Contains(x.ToString()))
                {
                    Console.WriteLine("true");
                }

                else
                {
                    Console.WriteLine(someQueue.Min());
                }
            }

            else
            {
                Console.WriteLine("0");
            }
        }
    }
}