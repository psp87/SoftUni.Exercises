using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "End")
            {
                List<string> inputSplited = input.Split(" ").ToList();
                string command = inputSplited[0];
                int number = 0;
                int count = 0;
                int index = 0;
                bool invalid = false;
                if (command == "Shift")
                {
                    count = int.Parse(inputSplited[2]);
                }
                else if (command == "Remove")
                {
                    index = int.Parse(inputSplited[1]);
                }
                else if (command == "Insert")
                {
                    number = int.Parse(inputSplited[1]);
                    index = int.Parse(inputSplited[2]);
                }
                else
                {
                    number = int.Parse(inputSplited[1]);
                }

                if (index < 0 || index >= numbers.Count)
                {
                    Console.WriteLine("Invalid index");
                    invalid = true;
                }

                if (!invalid)
                {
                    switch (command)
                    {
                        case "Add": numbers.Add(number); break;
                        case "Insert": numbers.Insert(index, number); break;
                        case "Remove": numbers.RemoveAt(index); break;
                        case "Shift":
                            {
                                if (inputSplited[1] == "left")
                                {
                                    for (int i = 0; i < count; i++)
                                    {
                                        numbers.Add(numbers[0]);
                                        numbers.Remove(numbers[0]);
                                    }
                                    break;
                                }
                                else
                                {
                                    for (int i = 0; i < count; i++)
                                    {
                                        numbers.Insert(0, numbers[numbers.Count - 1]);
                                        numbers.RemoveAt(numbers.Count - 1);
                                    }
                                    break;
                                }
                            }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
