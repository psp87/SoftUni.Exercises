using System;
using System.Collections.Generic;

namespace _04_LAB_CitiesByContinentCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!dict.ContainsKey(continent))
                {
                    dict[continent] = new Dictionary<string, List<string>>();
                }
                if (!dict[continent].ContainsKey(country))
                {
                    dict[continent][country] = new List<string>();
                }
                dict[continent][country].Add(city);
            }

            foreach (var continent in dict)
            {
                var continentName = continent.Key;
                var contries = continent.Value;
                Console.WriteLine($"{continentName}:");

                foreach (var country in contries)
                {
                    var countryName = country.Key;
                    var cities = country.Value;
                    Console.Write($"  {countryName} -> ");

                    Console.WriteLine(String.Join(", ", cities));
                }
            }
        }
    }
}
