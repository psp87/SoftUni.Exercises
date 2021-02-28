using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputSplited = input.Split(" -> ");

                string company = inputSplited[0];
                string id = inputSplited[1];

                if (!dict.ContainsKey(company))
                {
                    dict[company] = new List<string>();
                }

                if (!dict[company].Contains(id))
                {
                    dict[company].Add(id);
                }

                input = Console.ReadLine();
            }

            foreach (var i in dict)
            {
                Console.WriteLine($"{i.Key}");
                foreach (var x in i.Value)
                {
                    Console.WriteLine($"-- {x}");
                }
            }
        }
    }
}
