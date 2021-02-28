using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> result = input.Split(" ").ToList();
            while (input != "end")
            {
                List<string> inputSeparated = input.Split(" ").ToList();
                if (inputSeparated.Contains("Delete"))
                {
                    string number = inputSeparated[1];
                    for (int i = 0; i < result.Count; i++)
                    {
                        if (result.Contains($"{number}"))
                        {
                            result.Remove($"{number}");
                            i--;
                        }
                    }
                }
                if (inputSeparated.Contains("Insert"))
                {
                    string number = inputSeparated[1];
                    int position = int.Parse(inputSeparated[2]);
                    result.Insert(position, number);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", result)) ;
        }
    }
}
