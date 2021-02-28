using System;

namespace RadsToDegreees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double deg = 180 * rad / Math.PI;
            Console.WriteLine($"{deg:F0}");
        }
    }
}
