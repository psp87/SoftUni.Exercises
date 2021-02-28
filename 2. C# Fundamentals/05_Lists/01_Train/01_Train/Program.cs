using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagonPassengers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                if (input.Contains("Add"))
                {
                    //Making Input List
                    List<string> inputList = input.Split().ToList();

                    //Get Value to add
                    int value = int.Parse(inputList[1]);

                    wagonPassengers.Add(value);
                }

                else
                {
                    int value = int.Parse(input);
                    for (int i = 0; i < wagonPassengers.Count; i++)
                    {
                        if (value+wagonPassengers[i] <= maxCapacity)
                        {
                            wagonPassengers[i] += value;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", wagonPassengers));
        }
    }
}
