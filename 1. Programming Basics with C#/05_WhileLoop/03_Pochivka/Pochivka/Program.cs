using System;

namespace Pochivka
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyExcursion = double.Parse(Console.ReadLine());
            double savedMoney = double.Parse(Console.ReadLine());
            int days = 0;
            int counter = 0;

            while (savedMoney<moneyExcursion)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                days++;
                if (action=="save")    
                {
                    savedMoney += sum;
                    counter = 0;
                }
                else if (action=="spend")
                {
                    savedMoney -= sum;
                    counter++;
                    if (savedMoney < 0)
                    {
                        savedMoney = 0;
                    }
                    if (counter==5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{days}");
                        break;
                    }  
                }  
            }
            if (moneyExcursion <= savedMoney)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
