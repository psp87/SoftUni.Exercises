using System;

namespace Shivashki_Ceh
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int count = int.Parse(Console.ReadLine());
            double lenghtCover = 0.3 * 2 + double.Parse(Console.ReadLine());
            double widthCover = 0.3 * 2 + double.Parse(Console.ReadLine());
            double lenghtBox = (lenghtCover - 0.3 * 2) / 2;

            //Prices
            double pricesmCover = 7;
            double pricesmBox = 9;

            //Calculations
            double priceCover = lenghtCover * widthCover * count * pricesmCover;
            double priceBox = lenghtBox * lenghtBox * count * pricesmBox;

            double overallUSD = priceCover + priceBox;
            double overallBGN = overallUSD * 1.85;

            //Output
            Console.WriteLine($"{overallUSD:F2} USD");
            Console.WriteLine($"{overallBGN:F2} BGN");
        }
    }
}
