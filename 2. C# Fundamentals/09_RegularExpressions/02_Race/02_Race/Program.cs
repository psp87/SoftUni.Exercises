using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            Dictionary<string, double> dict = new Dictionary<string, double>();

            names = Console.ReadLine().Split(", ").ToList();

            string text = Console.ReadLine();

            string patternLetter = @"([A-Za-z]+)";
            string patternDigit = @"[0-9]";

            Regex regexLetters = new Regex(patternLetter);

            while (text != "end of race")
            {
                MatchCollection matchLetters = regexLetters.Matches(text);
                MatchCollection matchDigits = Regex.Matches(text, patternDigit);

                string name = String.Empty;
                double distance = 0.0;

                foreach (Match match in matchLetters)
                {
                    name += match.Value;
                }

                foreach (Match match in matchDigits)
                {
                    distance += double.Parse(match.Value);
                }

                if (names.Contains(name))
                {
                    if (dict.ContainsKey(name))
                    {
                        dict[name] += distance;
                    }
                    else
                    {
                        dict.Add(name, distance);
                    }
                }

                text = Console.ReadLine();
            }

            dict = dict
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);

            for (int i = 0; i < 3; i++)
            {
                string place = i == 0 ? "st" : i == 1 ? "nd" : "rd";
                Console.WriteLine($"{i+1}{place} place: {dict.Keys.ElementAt(i)}");
            }
        }
    }
}
