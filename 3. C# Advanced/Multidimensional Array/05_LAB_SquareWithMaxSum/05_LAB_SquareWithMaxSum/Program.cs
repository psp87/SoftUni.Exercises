using System;
using System.Linq;

namespace _05_LAB_SquareWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rowSize = sizes[0];
            int colSize = sizes[1];

            int[,] matrix = new int[rowSize, colSize];

            for (int row = 0; row < rowSize; row++)
            {
                int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < colSize; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int biggestSum = 0;
            int maxRowIndex = 0;
            int maxColIndex = 0;

            //int[,] biggestMatrix = new int[2, 2];

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > biggestSum)
                    {
                        biggestSum = sum;
                        maxRowIndex = row;
                        maxColIndex = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRowIndex,maxColIndex]} {matrix[maxRowIndex, maxColIndex+1]}");
            Console.WriteLine($"{matrix[maxRowIndex+1,maxColIndex]} {matrix[maxRowIndex+1, maxColIndex+1]}");
            Console.WriteLine(biggestSum);
        }
    }
}
