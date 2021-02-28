using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> someQueue = new Queue<int>(orders);

            Console.WriteLine(someQueue.Max());

            for (int i = 0; i < orders.Length; i++)
            {
                int currentNumber = orders[i];
                
                if (capacity >= currentNumber)
                {
                    capacity -= someQueue.Dequeue();
                }

                else
                {
                        Console.Write("Orders left: ");
                        Console.WriteLine(String.Join(" ", someQueue));
                        break;
                }
            }

            if (!someQueue.Any())
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
