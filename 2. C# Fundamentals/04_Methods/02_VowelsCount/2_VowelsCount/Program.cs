using System;

namespace _2_VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            GetVowelsCount(text);
        }

        static void GetVowelsCount(string a)
        {
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'A' || a[i] == 'a' || a[i] == 'E' || a[i] == 'e' || a[i] == 'I' || a[i] == 'i'
                    || a[i] == 'O' || a[i] == 'o' || a[i] == 'U' || a[i] == 'u')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
