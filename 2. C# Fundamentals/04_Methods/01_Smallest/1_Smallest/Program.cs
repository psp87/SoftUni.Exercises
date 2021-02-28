using System;

namespace _1_Smallest
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            GetSmallest(firstNumber, secondNumber, thirdNumber);
        }

        static void GetSmallest(int firstNumber, int secondNumber, int thirdNumber)
        {
            int min = 0;
            if (firstNumber <= secondNumber)
            {
                min = firstNumber;
            }
            else
            {
                min = secondNumber;
            }
            if (min <= thirdNumber)
            {
                Console.WriteLine(min);
            }
            else
            {
                Console.WriteLine(thirdNumber);
            }
        }
    }
}
