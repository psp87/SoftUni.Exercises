using System;

namespace _6_MiddleChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool even = GetEvenOdd(text);
            int division = text.Length / 2;

            if (even == true)
            {;
                Console.WriteLine($"{text[division - 1]}{text[division]}");
            }
            else
            {
                Console.WriteLine(text[division]);
            }
        }

        static bool GetEvenOdd(string text)
        {
            if (text.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
