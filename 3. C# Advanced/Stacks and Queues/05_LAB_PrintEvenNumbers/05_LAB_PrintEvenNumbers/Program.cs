using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_LAB_PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> someQueue = new Queue<int>(input);

            List<int> finalList = new List<int>();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    someQueue.Enqueue(input[i]);
            //}

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = someQueue.Dequeue();

                if (currentNumber % 2 == 0)
                {
                    finalList.Add(currentNumber);
                }
            }

            Console.WriteLine(String.Join(", ", finalList));
        }
    }
}
