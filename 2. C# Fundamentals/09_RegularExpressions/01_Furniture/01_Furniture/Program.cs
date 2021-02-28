using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01_Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @">>(?<name>\w+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";

            Regex regex = new Regex(pattern);

            double totalSum = 0.0;
            List<string> typesBought = new List<string>();

            while (input != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string type = match.Groups[1].Value;
                    double price = double.Parse(match.Groups[2].Value);
                    int quantity = int.Parse(match.Groups[3].Value);

                    typesBought.Add(type);
                    totalSum += price * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            foreach (var type in typesBought)
            {
                Console.WriteLine($"{type}");
            }

            Console.WriteLine($"Total money spend: {totalSum:F2}");
        }
    }
}
