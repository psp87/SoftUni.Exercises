using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = 1.79549 * usd;
            Console.WriteLine(Math.Round(bgn,2));
        }
    }
}