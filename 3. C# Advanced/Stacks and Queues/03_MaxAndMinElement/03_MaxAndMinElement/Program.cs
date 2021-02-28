using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MaxAndMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> someStack = new Stack<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] inputSplited = input.Split();

                int command = int.Parse(inputSplited[0]);

                switch (command)
                {
                    case 1:
                        string toAdd = inputSplited[1];
                        someStack.Push(toAdd);
                        break;
                    case 2:
                        if (someStack.Any())
                        {
                            someStack.Pop();
                        }
                        break;
                    case 3:
                        Console.WriteLine(someStack.Max());
                        break;
                    case 4:
                        Console.WriteLine(someStack.Min());
                        break;
                }
            }
            Console.WriteLine(String.Join(", ", someStack));
        }
    }
}
