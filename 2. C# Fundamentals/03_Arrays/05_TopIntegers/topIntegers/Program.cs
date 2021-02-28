using System;
using System.Linq;

namespace topIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int value = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        value = 0;
                        break;
                    }
                    else
                    {
                        value = arr[i];
                    }
                }
                if (value != 0)
                {
                    Console.Write(value + " ");
                    value = 0;
                }
            }
            Console.Write(arr[arr.Length - 1]);
        }
    }
}
