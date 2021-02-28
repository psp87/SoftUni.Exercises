using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_LAB_WordCount
{
    class Program
    {
        static void Main()
        {
            var dict = new Dictionary<string, int>();

            using (var readerWords = new StreamReader(@"03. Word Count\words.txt"))
            {
                string[] words = readerWords.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    string currentWord = words[i].ToLower();
                    dict[currentWord] = 0;
                }

                string pattern = @"[A-Za-z']+";
                Regex regex = new Regex(pattern);

                using (var readerText = new StreamReader(@"03. Word Count\text.txt"))
                {
                    using (var writer = new StreamWriter("Output.txt"))
                    {
                        string line = readerText.ReadLine();

                        while (line != null)
                        {
                            MatchCollection matches = regex.Matches(line);

                            foreach (Match item in matches)
                            {
                                string currentWord = item.Value.ToLower();
                                if (dict.ContainsKey(currentWord))
                                {
                                    dict[currentWord]++;
                                }
                            }
                            line = readerText.ReadLine();
                        }

                        dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);

                        foreach (var item in dict)
                        {
                            string word = item.Key;
                            int counter = item.Value;

                            writer.WriteLine($"{word} - {counter}");
                        }
                    }
                }
            }
        }
    }
}
