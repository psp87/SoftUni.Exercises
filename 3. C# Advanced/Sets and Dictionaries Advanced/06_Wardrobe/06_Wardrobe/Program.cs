using System;
using System.Collections.Generic;

namespace _06_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];

                string[] dresses = input[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!dict.ContainsKey(color))
                {
                    dict[color] = new Dictionary<string, int>();
                }

                foreach (var dress in dresses)
                {   
                    if (!dict[color].ContainsKey(dress))
                    {
                        dict[color][dress] = 0;
                    }
                    dict[color][dress]++;
                }
            }

            string[] lookFor = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string colorLookFpr = lookFor[0];
            string dressLookFpr = lookFor[1];

            foreach (var item in dict)
            {
                var color = item.Key;
                var dresses = item.Value;
                Console.WriteLine($"{color} clothes:");

                foreach (var kvp in dresses)
                {
                    var dress = kvp.Key;
                    var count = kvp.Value;

                    if (color == colorLookFpr && dress == dressLookFpr)
                    {
                        Console.WriteLine($"* {dress} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {dress} - {count}");
                    }
                }
            }
        }
    }
}
