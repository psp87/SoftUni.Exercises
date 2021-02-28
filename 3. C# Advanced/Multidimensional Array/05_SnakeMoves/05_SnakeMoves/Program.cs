using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            char[,] matrix = new char[rows, cols];

            string input = Console.ReadLine();

            //int difference = 0;

            //if (input.Length >= cols)
            //{
            //    for (int row = 0; row < rows; row++)
            //    {
            //        for (int col = 0; col < difference; col++)
            //        {
            //            matrix[row, col] = input[input.Length - difference + col];
            //        }

            //        for (int col = difference; col < cols; col++)
            //        {
            //            matrix[row, col] = input[col - difference];
            //        }
            //        difference = input.Length - cols + difference;
            //    }
            //}
            //else
            //{

            Queue<char> word = new Queue<char>(input);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    char currentSymbol = word.Dequeue();
                    matrix[row, col] = currentSymbol;
                    word.Enqueue(currentSymbol);
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
