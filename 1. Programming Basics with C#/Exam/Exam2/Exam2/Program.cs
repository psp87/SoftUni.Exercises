using System;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double towelPrice = double.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());

            double umbrellaPrice = (2 * towelPrice)/3;
            double flipFlopsPrice = umbrellaPrice * 0.75;
            double bagPrice = (towelPrice + flipFlopsPrice) / 3;

            double totalPrice = towelPrice + umbrellaPrice + flipFlopsPrice + bagPrice;

            double priceAfterDiscount = totalPrice - percentDiscount/100 * totalPrice;

            if (budget >= priceAfterDiscount)
            {
                Console.WriteLine($"Annie's sum is {priceAfterDiscount:F2} lv. She has {budget-priceAfterDiscount:F2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {priceAfterDiscount:F2} lv. She needs {priceAfterDiscount-budget:F2} lv. more.");
            }
        }
    }
}
