using System;
using System.Linq;

namespace _08_CustomComparator
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> sortFunc = (x, y) => x.CompareTo(y);

            Action<int[], int[]> print = (x, y) => Console.WriteLine($"{String.Join(" ", x)} {String.Join(" ", y)}");

            int[] evenNums = numbers.Where(x => x % 2 == 0).ToArray();
            int[] oddNums = numbers.Where(x => x % 2 != 0).ToArray();

            Array.Sort(evenNums, new Comparison<int>(sortFunc));
            Array.Sort(oddNums, new Comparison<int>(sortFunc));

            print(evenNums, oddNums);
        }
    }
}
