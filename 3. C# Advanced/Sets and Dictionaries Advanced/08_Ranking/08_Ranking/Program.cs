using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictContest = new Dictionary<string, string>();
            var dictUsers = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string contestData = Console.ReadLine();

                if (contestData == "end of contests")
                {
                    break;
                }

                string[] contestDataSplited = contestData
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);

                string contest = contestDataSplited[0];
                string pass = contestDataSplited[1];

                dictContest.Add(contest, pass);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of submissions")
                {
                    break;
                }

                string[] inputSplited = input
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string contestInput = inputSplited[0];
                string passInput = inputSplited[1];
                string user = inputSplited[2];
                int points = int.Parse(inputSplited[3]);

                if (dictContest.ContainsValue(passInput) && dictContest.ContainsKey(contestInput))
                {
                    if (!dictUsers.ContainsKey(user))
                    {
                        dictUsers[user] = new Dictionary<string, int>();
                    }

                    if (dictUsers[user].ContainsKey(contestInput))
                    {
                        if (dictUsers[user][contestInput] < points)
                        {
                            dictUsers[user][contestInput] = points;
                        }
                    }

                    else
                    {
                        dictUsers[user].Add(contestInput, points);
                    }
                }
            }

            var pointsDictionary = new Dictionary<string, int>();

            foreach (var kvp in dictUsers)
            {
                pointsDictionary[kvp.Key] = kvp.Value.Values.Sum();
            }

            int maxPoints = pointsDictionary
                .Values
                .Max();

            foreach (var kvp in pointsDictionary)
            {
                if (kvp.Value == maxPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");
                }
            }

            Console.WriteLine("Ranking:");
            foreach (var item in dictUsers)
            {
                var user = item.Key;
                var dictContestPoints = item.Value;
                dictContestPoints = dictContestPoints.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine(user);

                foreach (var kvp in dictContestPoints)
                {
                    var contest = kvp.Key;
                    var points = kvp.Value;

                    Console.WriteLine($"#  {contest} -> {points}");
                }
            }
        }
    }
}
