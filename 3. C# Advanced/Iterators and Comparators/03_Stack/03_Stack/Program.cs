using System;
using System.Linq;

namespace _03_Stack
{
    class Program
    {
        static void Main()
        {
            CustomStack<int> stack = new CustomStack<int>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] splittedInput = input
                    .Split(" ", 2);

                string command = splittedInput[0];

                if (command == "Push")
                {
                    int[] numbers = splittedInput[1]
                        .Split(", ")
                        .Select(int.Parse)
                        .ToArray();

                    stack.Push(numbers);
                }

                else
                {
                    try
                    {
                        stack.Pop();
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var number in stack)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
