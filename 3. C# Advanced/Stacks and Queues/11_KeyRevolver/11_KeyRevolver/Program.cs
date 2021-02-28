using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = int.Parse(Console.ReadLine());
            int sizeBarell = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] locks = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            Queue<int> locksQueue = new Queue<int>(locks);
            Stack<int> bulletsStack = new Stack<int>(bullets);

            int counterBullets = 0;

            while (bulletsStack.Any() && locksQueue.Any())
            {
                if (bulletsStack.Peek() <= locksQueue.Peek())
                {
                    counterBullets++;
                    bulletsStack.Pop();
                    locksQueue.Dequeue();
                    Console.WriteLine("Bang!");
                    if (counterBullets == sizeBarell && bulletsStack.Any())
                    {
                        Console.WriteLine("Reloading!");
                        counterBullets = 0;
                    }
                }

                else
                {
                    counterBullets++;
                    bulletsStack.Pop();
                    Console.WriteLine("Ping!");
                    if (counterBullets == sizeBarell && bulletsStack.Any())
                    {
                        Console.WriteLine("Reloading!");
                        counterBullets = 0;
                    }
                }
            }

            int moneyEarned = intelligence - ((bullets.Length - bulletsStack.Count) * price);

            if (!bulletsStack.Any() && locksQueue.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }

            else
            {
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${moneyEarned}");
            }
        }
    }
}
