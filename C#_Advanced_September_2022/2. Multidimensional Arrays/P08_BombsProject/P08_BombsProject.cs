using System;

namespace P08_BombsProject
{
    internal class P08_BombsProject
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int rows = size;
            int cols = size;

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                }
            }

            string[] bombsInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            int count = 0;

            for (int i = 0; i < bombsInput.Length; i++)
            {
                string[] bomb = bombsInput[0 + i].Split(",", StringSplitOptions.RemoveEmptyEntries);
                int rowBomb = int.Parse(bomb[0]);
                int colBomb = int.Parse(bomb[1]);

                int bombValue = matrix[rowBomb, colBomb];

                if (bombValue > 0)
                {
                    for (int k = rowBomb - 1; k < rowBomb + 2; k++)
                    {
                        for (int j = colBomb - 1; j < colBomb + 2; j++)
                        {
                            if (IsCellValid(k, j, size))
                            {
                                if (matrix[k, j] > 0)
                                {
                                    matrix[k, j] -= bombValue;
                                }
                            }
                        }
                    }
                }
            }

            foreach (var num in matrix)
            {
                if (num > 0)
                {
                    count++;
                    sum += num;
                }
            }

            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");
            PrintMatrix(rows, cols, matrix);

        }

        static bool IsCellValid(int row, int col, int size)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }

        static void PrintMatrix(int rows, int cols, int[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}