using System;

namespace _8_FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            double factorialFirst = Factorial(first);
            double factorialSecond = Factorial(second);
            Print(factorialFirst, factorialSecond);
        }

        static double Factorial(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x-1);
            }
        }

        static void Print(double a, double b)
        {
            double div = a / b;
            Console.WriteLine($"{div:F2}");
        }
    }
}
