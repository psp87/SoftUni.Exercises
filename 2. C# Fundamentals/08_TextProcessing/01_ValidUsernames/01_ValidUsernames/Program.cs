using System;
using System.Linq;
using System.Text;

namespace _01_ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            for (int i = 0; i < input.Length; i++)
            {
                string currentUser = input[i];
                bool isLengthValid = true;
                bool isSymbolValid = true;

                if (currentUser.Length < 3 || currentUser.Length > 16)
                {
                    isLengthValid = false;
                    continue;
                }

                for (int j = 0; j < currentUser.Length; j++)
                {
                    char currentSymbol = currentUser[j];

                    if (!(char.IsLetterOrDigit(currentSymbol) || currentSymbol == '-' || currentSymbol == '_'))
                    {
                        isSymbolValid = false;
                        break;
                    }
                }

                if (isLengthValid && isSymbolValid)
                {
                    Console.WriteLine(currentUser);
                }
            }
        }
    }
}
