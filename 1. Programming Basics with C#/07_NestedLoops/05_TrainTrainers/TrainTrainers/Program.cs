using System;

namespace TrainTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            double average = 0;
            double counter = 0;
            while (name != "Finish")
            {
                double sum = 0;
                double assessment = 0;
                for (int i = 1; i <= n; i++)
                {
                    assessment = double.Parse(Console.ReadLine());
                    sum += assessment;
                    average += assessment;
                    counter++;
                }
                sum /= n;
                Console.WriteLine($"{name} - {sum:F2}.");
                name = Console.ReadLine();
            }
        }
    }
}
