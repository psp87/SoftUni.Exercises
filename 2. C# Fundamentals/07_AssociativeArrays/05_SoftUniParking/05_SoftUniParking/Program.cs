using System;
using System.Collections.Generic;

namespace _05_SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputSplited = Console.ReadLine().Split(" ");

                string command = inputSplited[0];
                string user = inputSplited[1];

                if (command == "register")
                {
                    string plateNumber = inputSplited[2];

                    if (dict.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }

                    else
                    {
                        dict.Add(user, plateNumber);
                        Console.WriteLine($"{user} registered {plateNumber} successfully");
                    }
                }
                
                else
                {
                    if (!dict.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        dict.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
