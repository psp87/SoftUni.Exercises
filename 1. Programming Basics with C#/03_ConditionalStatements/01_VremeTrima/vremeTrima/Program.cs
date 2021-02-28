using System;

namespace vremeTrima
{
    class Program
    {
        static void Main(string[] args)
        {
            int t1 = int.Parse(Console.ReadLine());
            int t2 = int.Parse(Console.ReadLine());
            int t3 = int.Parse(Console.ReadLine());
            int t4 = t1 + t2 + t3;
            int minutes = t4 / 60;
            int seconds = t4 % 60;
            if (seconds > 10)
            {
                Console.WriteLine($"The total time of three men is {minutes}:{seconds}");
            }
            else
            {
                Console.WriteLine($"The total time of three men is {minutes}:0{seconds}");
            }
        }
    }
}
