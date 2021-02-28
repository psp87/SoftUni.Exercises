using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Socks
{
    class Program
    {
        static void Main()
        {
            int[] leftSocksInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] rightSocksInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            Stack<int> leftSocks = new Stack<int>(leftSocksInput);

            Queue<int> rightSocks = new Queue<int>(rightSocksInput);

            List<int> sets = new List<int>();

            while(leftSocks.Any() && rightSocks.Any())
            {
                int leftSock = leftSocks.Pop();
                int rightSock = rightSocks.Peek();

                if (leftSock > rightSock)
                {
                    int setValue = leftSock + rightSock;
                    sets.Add(setValue);
                    rightSocks.Dequeue();
                }

                else if (leftSock == rightSock)
                {
                    rightSocks.Dequeue();
                    int leftSockIncrement = leftSock + 1;
                    leftSocks.Push(leftSockIncrement);
                }
            }

            Console.WriteLine(sets.Max());

            Console.WriteLine(string.Join(" ", sets));
        }
    }
}
