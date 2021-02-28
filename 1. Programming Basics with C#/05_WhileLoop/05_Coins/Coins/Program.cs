using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double counter = 0;

            while (change!=0)
            {
                if (change>=2)
                {
                    change-=2;
                    counter++;
                }
                else if (change >= 1)
                {
                    change -= 1;
                    counter++;
                }
                else if (change >= 0.50)
                {
                    change -= 0.50;
                    counter++;
                }
                else if (change >= 0.20)
                {
                    change -= 0.20;
                    counter++;
                }
                else if (change >= 0.10)
                {
                    change -= 0.10;
                    counter++;
                }
                else if (change >= 0.05)
                {
                    change -= 0.05;
                    counter++;
                }
                else if (change >= 0.02)
                {
                    change -= 0.02;
                    counter++;
                }
                else if (change >= 0.01)
                {
                    change -= 0.01;
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
