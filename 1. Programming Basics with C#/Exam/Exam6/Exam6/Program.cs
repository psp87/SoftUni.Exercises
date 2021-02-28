using System;

namespace Exam6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int totalCount = 0;
            double totalSum = 0.0;

            for (int i = 1; i <= count; i++)
            {
                int countCookies = 0;
                int countCakes = 0;
                int countWaffles = 0;

                string name = Console.ReadLine();
                string typeMeal = Console.ReadLine();

                while (typeMeal != "Stop baking!")
                {
                    int countMeal = int.Parse(Console.ReadLine());

                    if (typeMeal == "cookies")
                    {
                        countCookies += countMeal;
                    }

                    else if (typeMeal == "cakes")
                    {
                        countCakes += countMeal;
                    }

                    else
                    {
                        countWaffles += countMeal;
                    }

                    typeMeal = Console.ReadLine();
                }

                totalCount += countCookies + countCakes + countWaffles;
                totalSum += (countCookies * 1.5) + (countCakes * 7.8) + (countWaffles * 2.3);

                Console.WriteLine($"{name} baked {countCookies} cookies, {countCakes} cakes and {countWaffles} waffles.");
            }

            Console.WriteLine($"All bakery sold: {totalCount}");
            Console.WriteLine($"Total sum for charity: {totalSum:F2} lv.");
        }
    }
}
