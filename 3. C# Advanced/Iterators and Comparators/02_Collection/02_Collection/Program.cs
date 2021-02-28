using System;
using System.Linq;

namespace _02_Collection
{
    class Program
    {
        static void Main()
        {
            ListyIterator<string> listyIterator = null;

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] splittedInput = input.Split();

                string command = splittedInput[0];

                if (command == "Create")
                {
                    listyIterator = new ListyIterator<string>(splittedInput.Skip(1).ToList());
                }

                else if (command == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }

                else if (command == "Print")
                {
                    Console.WriteLine(listyIterator.Print());
                }

                else if (command == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }

                else if (command == "PrintAll")
                {
                    Console.WriteLine(String.Join(" ", listyIterator));

                    //foreach (var element in listyIterator)
                    //{
                    //    Console.Write(element + " ");
                    //}
                }

                input = Console.ReadLine();
            }
        }
    }
}
