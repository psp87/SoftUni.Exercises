using System;

namespace _4_PassValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            int firstCheck = LookCharacters(pass);
            int secondCheck = LookOnlyLettersAndDigits(pass);
            int thirdChech = LookLeast2Digits(pass);

            if (firstCheck == 1 && secondCheck == 1 && thirdChech == 1)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static int LookCharacters(string pass)
        {
            if (pass.Length < 6 || pass.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return 0;
            }
            return 1;
        }

        static int LookOnlyLettersAndDigits(string pass)
        {
            for (int i = 0; i < pass.Length; i++)
            {
                if ((pass[i] >= 48 && pass[i] <= 57) || (pass[i] >= 65 && pass[i] <= 90) || (pass[i] >= 97 && pass[i] <= 122))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return 0;
                }
            }
            return 1;
        }
        static int LookLeast2Digits(string pass)
        {
            int counterDigits = 0;

            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] >= 48 && pass[i] <= 57)
                {
                    counterDigits++;
                    if (counterDigits >= 2)
                    {
                        return 1;
                    }
                }
            }
            Console.WriteLine("Password must have at least 2 digits");
            return 0;
        }
    }
}