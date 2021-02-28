using System;
using System.Linq;

namespace _01_DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = values[col];
                }
            }

            int sumOne = 0;
            int sumTwo = 0;

            for (int i = 0; i < size; i++)
            {
                sumOne += matrix[i, i];
            }

            int cl = size;

            for (int row = 0; row < size; row++)
            {
                cl--;
                sumTwo += matrix[row, cl];
            }

            int absDifference = Math.Abs(sumOne - sumTwo);

            Console.WriteLine(absDifference);
        }
    }
}
