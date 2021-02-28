using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputSplitted = input.Split(" : ");

                string course = inputSplitted[0];
                string student = inputSplitted[1];

                if (!dictionary.ContainsKey(course))
                {
                    dictionary[course] = new List<string>();
                }

                dictionary[course].Add(student);

                input = Console.ReadLine();
            }

            foreach (var kvp in dictionary.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var i in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {i}");
                }
            }
        }
    }
}
