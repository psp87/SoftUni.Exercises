using System;

namespace Lodka
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            double result = 0;
            double eo = 0;

            switch (oper)
            {
                case "+":
                    result = N1 + N2;
                    eo = result % 2;
                    if (eo == 0)
                    {
                        Console.WriteLine($"{N1} {oper} {N2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {oper} {N2} = {result} - odd");
                    }
                    break;
                case "-":
                    result = N1 - N2;
                    eo = result % 2;
                    if (eo == 0)
                    {
                        Console.WriteLine($"{N1} {oper} {N2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {oper} {N2} = {result} - odd");
                    }
                    break;
                case "*":
                    result = N1 * N2;
                    eo = result % 2;
                    if (eo == 0)
                    {
                        Console.WriteLine($"{N1} {oper} {N2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {oper} {N2} = {result} - odd");
                    }
                    break;
                case "/":
                    if (!(N2 == 0))
                    {
                        result = N1 / N2;
                        Console.WriteLine($"{N1} {oper} {N2} = {result:F2}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    break;
                case "%":
                    if (!(N2 == 0))
                    {
                        result = N1 % N2;
                        Console.WriteLine($"{N1} {oper} {N2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    break;
            }
        }
    }
}
