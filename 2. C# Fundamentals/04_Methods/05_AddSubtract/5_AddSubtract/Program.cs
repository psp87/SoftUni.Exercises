using System;

namespace _5_AddSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = Sum(a, b);
            int result = Subtract(sum, c);
            Console.WriteLine(result);
        }

        static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static int Subtract(int sum, int c)
        {
            int result = sum - c;
            return result;
        }
    }
}
