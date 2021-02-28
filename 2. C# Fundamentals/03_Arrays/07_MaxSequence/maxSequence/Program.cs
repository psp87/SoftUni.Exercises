using System;
using System.Linq;

namespace maxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int tempCounter = 1;
            int maxCounter = 1;
            string number = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    tempCounter++;
                    if (tempCounter > maxCounter)
                    {
                        maxCounter = tempCounter;
                        number = arr[i];
                    }
                }

                else
                {
                    tempCounter = 1;
                }
            }

            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write(number + " ");
            }
        }
    }
}