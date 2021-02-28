using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_LAB_ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> someStack = new Stack<char>(input);

            //for (int i = 0; i < input.Length; i++)
            //{
            //    someStack.Push(input[i]);
            //}

            while (someStack.Count != 0)
            {
                Console.Write(someStack.Pop());
            }
        }
    }
}
