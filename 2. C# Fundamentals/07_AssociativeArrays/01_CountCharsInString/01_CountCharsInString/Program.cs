using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var counts = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (letter != ' ')
                {
                    if (counts.ContainsKey(letter))
                    {
                        counts[letter]++;
                    }

                    else
                    {
                        counts[letter] = 1;
                    }
                }
            }

            //Console.WriteLine(String.Join(Environment.NewLine, counts));

            foreach (var i in counts)
            {
                Console.WriteLine($"{i.Key} -> {i.Value}");
            }
        }
    }
}
