using System;
using System.Linq;

namespace _03_PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int totalSum = 0;

            for (int i = 0; i < size; i++)
            {
                totalSum += matrix[i, i];
            }

            Console.WriteLine(totalSum);
        }
    }
}
