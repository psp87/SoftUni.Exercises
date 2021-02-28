using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] people = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                sum += people[i];
            }

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.Write(people[i] + " ");
            //    sum += people[i];
            //}

            //foreach (int i in people)
            //{
            //    Console.Write($"{i} ");
            //    sum += i;
            //}

            Console.WriteLine(string.Join(" ", people));
            Console.WriteLine(sum);
        }
    }
}
