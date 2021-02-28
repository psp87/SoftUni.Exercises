using System;

namespace VlojeniCikli
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string shoes = string.Empty;
            string outfit = string.Empty;
            
            if (temperature >= 10 && temperature <= 18)
            {
                if (time == "Morning")
                {
                    shoes = "Sneakers";
                    outfit = "Sweatshirt";
                }
                else if (time == "Afternoon")
                {
                    shoes = "Moccasins";
                    outfit = "Shirt";
                }
                else if (time == "Evening")
                {
                    shoes = "Moccasins";
                    outfit = "Shirt";
                }
            }
            else if (temperature > 18 && temperature <= 24)
            {
                if (time == "Morning")
                {
                    shoes = "Moccasins";
                    outfit = "Shirt";
                }
                else if (time == "Afternoon")
                {
                    shoes = "Sandals";
                    outfit = "T-Shirt";
                }
                else if (time == "Evening")
                {
                    shoes = "Moccasins";
                    outfit = "Shirt";
                }
            }
            else if (temperature >= 25)
            {
                if (time == "Morning")
                {
                    shoes = "Sandals";
                    outfit = "T-Shirt";
                }
                else if (time == "Afternoon")
                {
                    shoes = "Barefoot";
                    outfit = "Swim Suit";
                }
                else if (time == "Evening")
                {
                    shoes = "Moccasins";
                    outfit = "Shirt";
                }
            }
            Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
        }
    }
}
