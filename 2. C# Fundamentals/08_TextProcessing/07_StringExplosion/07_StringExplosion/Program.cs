using System;
using System.Text;
using System.Linq;

namespace _07_StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] inputSplited = input.Split(">");

            string result = inputSplited[0];

            int remainingPower = 0;

            for (int i = 1; i < inputSplited.Length; i++)
            {
                result += ">";

                string currentString = inputSplited[i];
                string currentDigit = currentString[0].ToString();

                int power = int.Parse(currentDigit) + remainingPower;

                if (power > currentString.Length)
                {
                    remainingPower = power - currentString.Length;
                }

                else
                {
                    result += currentString.Substring(power);
                }
            }

            Console.WriteLine(result);


            //string input = Console.ReadLine();

            //int counter = 0;
            //int strength = 0;
            //int row = 0;

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] == '>')
            //    {
            //        strength = int.Parse(input[i + 1].ToString());

            //        for (int j = 1; j <= strength; j++)
            //        {
            //            row++;
            //            input = input.Remove(i + 1, 1);

            //            if (counter > 0 && input[i + 1] != '>')
            //            {
            //                input = input.Remove(i + 1, 1);
            //                counter--;
            //            }

            //            if (input[i+1] == '>')
            //            {
            //                counter = strength - row;
            //                row = 0;
            //                break;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine(input);
        }
    }
}
