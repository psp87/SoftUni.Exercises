using System;
using System.Collections.Generic;

namespace _04_EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(number))
                {
                    dict[number] = 0;
                }
                dict[number]++;
            }

            foreach (var item in dict)
            {
                int times = item.Value;
                int number = item.Key;

                if (times % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
