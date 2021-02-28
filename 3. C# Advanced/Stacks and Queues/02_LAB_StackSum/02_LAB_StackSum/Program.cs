using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_LAB_StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> someStack = new Stack<int>(input);

            string operation = Console.ReadLine().ToLower();

            while (operation != "end")
            {
                string[] operationSplited = operation.Split();

                string command = operationSplited[0];
                int firstNumber = int.Parse(operationSplited[1]);

                if (command == "add")
                {
                    int secondNumber = int.Parse(operationSplited[2]);

                    someStack.Push(firstNumber);
                    someStack.Push(secondNumber);
                }

                else
                {
                    if (someStack.Count < firstNumber)
                    {
                        operation = Console.ReadLine().ToLower();
                        continue;
                    }

                    for (int i = 0; i < firstNumber; i++)
                    {
                        someStack.Pop();
                    }
                }

                operation = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {someStack.Sum()}");
        }
    }
}
