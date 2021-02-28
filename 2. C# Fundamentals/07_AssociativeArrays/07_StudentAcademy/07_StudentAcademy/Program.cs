using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!dict.ContainsKey(student))
                {
                    dict[student] = new List<double>();
                }

                dict[student].Add(grade);
            }

            dict = dict
                .Where(x => x.Value.Average() >= 4.5)
                .OrderByDescending(y => y.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():F2}");
            }
        }
    }
}
