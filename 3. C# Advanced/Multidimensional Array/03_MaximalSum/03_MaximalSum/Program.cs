using System;
using System.Linq;

namespace _02_2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rowSize = sizes[0];
            int colSize = sizes[1];

            int[,] matrix = new int[rowSize, colSize];

            for (int row = 0; row < rowSize; row++)
            {
                int[] values = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < colSize; col++)
                {
                    matrix[row, col] = values[col];
                }
            }

            int maxSum = int.MinValue;
            int indexRow = 0;
            int indexCol = 0;

            int sum = 0;

            for (int row = 0; row < rowSize - 2; row++)
            {
                for (int col = 0; col < colSize - 2; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        indexRow = row;
                        indexCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[indexRow, indexCol]} {matrix[indexRow, indexCol+1]} {matrix[indexRow, indexCol + 2]}");
            Console.WriteLine($"{matrix[indexRow+1, indexCol]} {matrix[indexRow+1, indexCol+1]} {matrix[indexRow+1, indexCol + 2]}");
            Console.WriteLine($"{matrix[indexRow+2, indexCol]} {matrix[indexRow+2, indexCol+1]} {matrix[indexRow+2, indexCol + 2]}");
        }
    }
}