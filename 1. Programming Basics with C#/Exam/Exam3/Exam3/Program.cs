using System;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruise = Console.ReadLine();
            string cabin = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double price = 0;

            if (cabin == "standard cabin")
            {
                if (cruise == "Mediterranean")
                {
                    price = 27.5;
                }
                else if (cruise == "Adriatic")
                {
                    price = 22.99;
                }
                else if (cruise == "Aegean")
                {
                    price = 23;
                }
            }

            else if (cabin == "cabin with balcony")
            {
                if (cruise == "Mediterranean")
                {
                    price = 30.2;
                }
                else if (cruise == "Adriatic")
                {
                    price = 25;
                }
                else if (cruise == "Aegean")
                {
                    price = 26.6;
                }
            }

            else
            {
                if (cruise == "Mediterranean")
                {
                    price = 40.5;
                }
                else if (cruise == "Adriatic")
                {
                    price = 34.99;
                }
                else if (cruise == "Aegean")
                {
                    price = 39.8;
                }
            }

            double totalPrice = price * 4 * nights;

            if (nights > 7)
            {
                totalPrice -= totalPrice * 0.25;
            }

            Console.WriteLine($"Annie's holiday in the {cruise} sea costs {totalPrice:F2} lv.");
        }
    }
}
