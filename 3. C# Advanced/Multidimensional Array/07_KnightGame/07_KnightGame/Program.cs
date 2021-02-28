using System;

namespace _07_KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int counter = 0;

            while (true)
            {
                int knightRow = 0;
                int knightCol = 0;
                int knightAttacks = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        char currentSymbol = matrix[row, col];

                        if (currentSymbol == 'K')
                        {
                            int tempAttack = CountAttack(matrix, row, col);

                            if (tempAttack > knightAttacks)
                            {
                                knightRow = row;
                                knightCol = col;
                                knightAttacks = tempAttack;
                            }
                        }
                    }
                }

                if (knightAttacks > 0)
                {
                    matrix[knightRow, knightCol] = '0';
                    counter++;
                }
                
                else
                {
                    break;
                }
            }

            Console.WriteLine(counter);
        }

        private static int CountAttack(char[,] matrix, int x, int y)
        {
            int attacks = 0;

            if (IsInMatrix(x - 1, y - 2, matrix.GetLength(0)) && matrix[x - 1,y - 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(x - 1, y + 2, matrix.GetLength(0)) && matrix[x - 1,y + 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(x - 2, y - 1, matrix.GetLength(0)) && matrix[x - 2,y - 1] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(x - 2, y + 1, matrix.GetLength(0)) && matrix[x - 2,y + 1] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(x + 1, y - 2, matrix.GetLength(0)) && matrix[x + 1,y - 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(x + 1, y + 2, matrix.GetLength(0)) && matrix[x + 1,y + 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(x + 2, y - 1, matrix.GetLength(0)) && matrix[x + 2,y - 1] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(x + 2, y + 1, matrix.GetLength(0)) && matrix[x + 2,y + 1] == 'K')
            {
                attacks++;
            }

            return attacks;
        }
        private static bool IsInMatrix(int x, int y, int length)
        {
            return x >= 0 && x < length && y >= 0 && y < length;
        }
    }
}
