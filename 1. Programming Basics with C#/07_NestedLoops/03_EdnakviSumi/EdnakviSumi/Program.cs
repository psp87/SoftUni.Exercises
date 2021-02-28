using System;

namespace EdnakviSumi
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            for (int i = number1; i <= number2; i++)
            {
                int x = i / 100000;
                int y = i / 10000 % 10;
                int z = i / 1000 % 10;
                int a = i / 100 % 10;
                int b = i / 10 % 10;
                int c = i % 10;

                int sumOdd = x + z + b;
                int sumEven = a + y + c;

                if (sumOdd == sumEven)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}