using System;
using System.Linq;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            double lemons = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());

            double lemonJuice = lemons * 980;

            double totalJuice = lemonJuice + water * 1000 + (0.3 * sugar);

            double count = Math.Floor(totalJuice / 150);
            double win = count * 1.20;

            Console.WriteLine($"All cups sold: {count}");
            Console.WriteLine($"Money earned: {win:F2}");
        }
    }
}
 