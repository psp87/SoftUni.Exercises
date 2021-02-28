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

            char[,] matrix = new char[rowSize, colSize];

            for (int row = 0; row < rowSize; row++)
            {
                char[] values = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < colSize; col++)
                {
                    matrix[row, col] = values[col];
                }
            }

            int totalCounter = 0;

            for (int row = 0; row < rowSize - 1; row++)
            {
                for (int col = 0; col < colSize - 1; col++)
                {
                    if (matrix[row,col] == matrix[row,col+1] && matrix[row, col] == matrix[row+1, col] && matrix[row,col] == matrix[row+1, col+1])
                    {
                        totalCounter++;
                    }
                }
            }

            Console.WriteLine(totalCounter);
        }
    }
}
