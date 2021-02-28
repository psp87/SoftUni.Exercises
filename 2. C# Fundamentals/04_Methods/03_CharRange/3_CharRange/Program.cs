    using System;

    namespace _3_CharRange
    {
        class Program
        {
            static void Main(string[] args)
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                PrintCharacters(firstChar, secondChar);
            }       

            static void PrintCharacters(char first, char second)
            {
                if (first <= second)
                {
                    for (int i = first + 1; i < second; i++)
                    {
                        Console.Write($"{(char)i} ");
                    }
                }
                else
                {
                    for (int i = second + 1; i < first; i++)
                    {
                        Console.Write($"{(char)i} ");
                    }
                }
            }
        }
    }
