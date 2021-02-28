using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_ReverseAndExclude
{
    class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            Predicate<int> isDivisible = x => x % n == 0;

            for (int i = 0; i < nums.Count; i++)
            {
                if (isDivisible(nums[i]))
                {
                    nums.Remove(nums[i]);
                    i--;
                }
            }

            nums.Reverse();

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
