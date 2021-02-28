using System;

namespace _02_CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputSplited = Console.ReadLine().Split(" ");
            string str1 = inputSplited[0];
            string str2 = inputSplited[1];
            int totalSum = 0;

            totalSum = Multiplier(str1, str2);

            Console.WriteLine(totalSum);
        }

        static int Multiplier(string a, string b)
        {
            int sum = 0;
            string min = string.Empty;
            string max = string.Empty;

            if (a.Length > b.Length)
            {
                min = b;
                max = a;
            }
            
            else
            {
                min = a;
                max = b;
            }

            for (int i = 0; i < min.Length; i++)
            {
                sum += min[i] * max[i];
            }

            for (int j = min.Length; j < max.Length; j++)
            {
                sum += max[j];
            }

            return sum;
        }

        //static int Multiplier(string a, string b)
        //{
        //    int sum = 0;

        //    if (a.Length > b.Length)
        //    {
        //        for (int i = 0; i < b.Length; i++)
        //        {
        //            sum += a[i] * b[i];
        //        }

        //        for (int j = b.Length; j < a.Length; j++)
        //        {
        //            sum += a[j];
        //        }

        //        return sum;
        //    }

        //    else if (a.Length < b.Length)
        //    {
        //        for (int i = 0; i < a.Length; i++)
        //        {
        //            sum += a[i] * b[i];
        //        }

        //        for (int j = a.Length; j < b.Length; j++)
        //        {
        //            sum += b[j];
        //        }

        //        return sum;
        //    }

        //    else
        //    {
        //        for (int i = 0; i < a.Length; i++)
        //        {
        //            sum += a[i] * b[i];
        //        }

        //        return sum;
        //    }
    }
}
