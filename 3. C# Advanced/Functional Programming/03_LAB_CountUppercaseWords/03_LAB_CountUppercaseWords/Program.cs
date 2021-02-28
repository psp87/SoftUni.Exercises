using System;
using System.Linq;

namespace _03_LAB_CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = w => char.IsUpper(w[0]);

            Console.ReadLine()
                .Split()
                .Where(checker)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
