using System;

namespace _04_CeasarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                int currentSymbol = input[i] + 3;
                Console.Write((char)currentSymbol);
            }
        }
    }
}
