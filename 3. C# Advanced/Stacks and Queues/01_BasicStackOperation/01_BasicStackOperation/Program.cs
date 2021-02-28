using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_BasicStackOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayCommands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = arrayCommands[0];
            int s = arrayCommands[1];
            int x = arrayCommands[2];

            string[] numbers = Console.ReadLine().Split();

            Stack<string> someStack = new Stack<string>(numbers);

            for (int i = 0; i < s; i++)
            {
                someStack.Pop();
            }

            if (someStack.Any())
            {
                if (someStack.Contains(x.ToString()))
                {
                    Console.WriteLine("true");
                }

                else
                {
                    Console.WriteLine(someStack.Min()); 
                }
            }

            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
