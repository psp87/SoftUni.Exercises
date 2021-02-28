using System;

namespace pluvaneWorldRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsMeter = double.Parse(Console.ReadLine());
            double delay = Math.Floor(distance / 15) * 12.5;
            double totalTime = distance * secondsMeter + delay;

            if (totalTime < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime-worldRecord:F2} seconds slower.");
            }
        }
    }
}
