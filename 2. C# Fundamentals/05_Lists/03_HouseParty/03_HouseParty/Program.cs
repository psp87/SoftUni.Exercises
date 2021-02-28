using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> finalResult = new List<string>();
            for (int i = 0; i < count; i++)          
            {
                List<string> input = Console.ReadLine().Split(" ").ToList();
                string name = input[0];
                if (input.Contains("not"))
                {
                    if (finalResult.Contains(name))
                    {
                        finalResult.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {
                    if (finalResult.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        finalResult.Add(name);
                    }
                }
            }
            Console.WriteLine(String.Join("\n", finalResult));
        }
    }
}
