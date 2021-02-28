using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyResources = new Dictionary<string, int>();
            keyResources["shards"] = 0;
            keyResources["fragments"] = 0;
            keyResources["motes"] = 0;

            var junk = new SortedDictionary<string, int>();

            bool isBreak = false;

            while (!isBreak)
            {
                string[] input = Console.ReadLine().ToLower().Split(" ");

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i+1];

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyResources[material] += quantity;
                        if (keyResources[material] >= 250)
                        {
                            string keyword = string.Empty;
                            switch (material)
                            {
                                case "shards": keyword = "Shadowmourne"; break;
                                case "fragments": keyword = "Valanyr"; break;
                                case "motes": keyword = "Dragonwrath"; break;
                            }
                            Console.WriteLine($"{keyword} obtained!");
                            keyResources[material] -= 250;
                            isBreak = true;
                            break;
                        }
                    }

                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk[material] = 0;
                        }

                        junk[material] += quantity;
                    }
                }
            }

            keyResources = keyResources.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in keyResources)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
