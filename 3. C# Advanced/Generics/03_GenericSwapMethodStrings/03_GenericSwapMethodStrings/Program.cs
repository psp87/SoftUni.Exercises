namespace _03_GenericSwapMethodStrings
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            Box<string> box = new Box<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }

            string command = Console.ReadLine();

            Swap(box.Data, command);

            Console.WriteLine(box);
        }

        static void Swap<T>(List<T> list, string command)
        {
            string[] commandSplitted = command.Split();
            int firstIndex = int.Parse(commandSplitted[0]);
            int secondIndex = int.Parse(commandSplitted[1]);

            var temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }
    }
}
