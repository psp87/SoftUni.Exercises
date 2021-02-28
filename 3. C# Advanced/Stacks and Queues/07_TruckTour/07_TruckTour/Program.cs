using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _07_TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int> diff = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int currentFuel = numbers[0];
                int currentDistance = numbers[1];

                diff.Enqueue(currentFuel - currentDistance);
            }

            int index = 0;

            while (true)
            {
                Queue<int> copyDiff = new Queue<int>(diff);

                int fuel = -1;

                while (copyDiff.Any())
                {
                    if (copyDiff.Peek() > 0 && fuel == -1)
                    {
                        fuel = copyDiff.Dequeue();
                        diff.Enqueue(diff.Dequeue());
                    }

                    else if (copyDiff.Peek() < 0 && fuel == -1)
                    {
                        copyDiff.Enqueue(copyDiff.Dequeue());
                        diff.Enqueue(diff.Dequeue());
                        index++;
                    }

                    else
                    {
                        fuel += copyDiff.Dequeue();

                        if (fuel < 0)
                        {
                            break;
                        }
                    }
                }

                if (fuel >= 0)
                {
                    Console.WriteLine(index);
                    return;
                }
                index++;
            }
        }
    }
}
