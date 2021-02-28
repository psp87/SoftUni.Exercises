using System;

namespace Exam4
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket = Console.ReadLine();

            string ticketMin = string.Empty;
            double priceMin = 0;
            int minMinutes = int.MaxValue;

            double totalPrice = 0;

            while (ticket != "End")
            {
                double price = double.Parse(Console.ReadLine());
                int minutes = int.Parse(Console.ReadLine());

                totalPrice = price * 1.96;

                if (minutes < minMinutes)
                {
                    ticketMin = ticket;
                    priceMin = totalPrice;
                    minMinutes = minutes;
                }

                ticket = Console.ReadLine();
            }

            int hours = minMinutes / 60;
            int minutesAfterCalc = minMinutes % 60;

            Console.WriteLine($"Ticket found for flight {ticketMin} costs {priceMin:F2} leva with {hours}h {minutesAfterCalc}m stay");
        }
    }
}
