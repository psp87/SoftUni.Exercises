using System;
using System.Text;

namespace _06_ReplaceRepeatChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                char currentSymbol = input[i];
                char previousSymbol = input[i - 1];

                if (currentSymbol != previousSymbol)
                {
                    sb.Append(currentSymbol);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
