using System;
using System.Linq;

namespace P10_RadioactiveMutantVampireBunniesExam
{
    internal class P10_RadioactiveMutantVampireBunniesExam
    {
        static void Main(string[] args)
        {
            int[] fieldSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = fieldSize[0];
            int cols = fieldSize[1];

            char[,] matrix = new char[rows, cols];

            int currRow = 0;
            int currCol = 0;

            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    if (input[col] == 'P')
                    {
                        currRow = row;
                        currCol = col;
                    }
                    matrix[row, col] = input[col];
                }
            }

            string directions = Console.ReadLine();

            foreach (var move in directions)
            {
                bool playerWon = false;
                bool playerLost = false;

                int newPlayerRow = currRow;
                int newPlayerCol = currCol;

                switch (move)
                {
                    case 'U':
                        matrix[currRow, currCol] = '.';
                        newPlayerRow--;
                        MovePlayer(newPlayerRow, currCol, matrix, ref playerWon, ref playerLost);
                        break;
                    case 'D':
                        matrix[currRow, currCol] = '.';
                        newPlayerRow++;
                        MovePlayer(newPlayerRow, currCol, matrix, ref playerWon, ref playerLost);
                        break;
                    case 'L':
                        matrix[currRow, currCol] = '.';
                        newPlayerCol--;
                        MovePlayer(currRow, newPlayerCol, matrix, ref playerWon, ref playerLost);
                        break;
                    case 'R':
                        matrix[currRow, currCol] = '.';
                        newPlayerCol++;
                        MovePlayer(currRow, newPlayerCol, matrix, ref playerWon, ref playerLost);
                        break;
                }

                matrix = SpreadBunnies(matrix, ref playerLost);

                if (playerWon)
                {
                    PrintMatrix(matrix);
                    Console.WriteLine($"won: {currRow} {currCol}");

                    return;
                }

                currRow = newPlayerRow;
                currCol = newPlayerCol;

                if (playerLost)
                {
                    PrintMatrix(matrix);
                    Console.WriteLine($"dead: {currRow} {currCol}");

                    return;
                }
            }
        }

        static void MovePlayer(int playerRow, int playerCol, char[,] matrix, ref bool playerWon, ref bool playerLost)
        {
            if (IsCellValid(playerRow, playerCol, matrix))
            {
                if (matrix[playerRow, playerCol] == 'B')
                {
                    playerLost = true;
                }
                else
                {
                    matrix[playerRow, playerCol] = 'P';
                }
            }
            else
            {
                playerWon = true;
            }
        }

        static char[,] SpreadBunnies(char[,] matrix, ref bool playerLost)
        {
            char[,] newMatrix = CopyMatrix(matrix);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        if (IsCellValid(row - 1, col, matrix))
                        {
                            if (matrix[row - 1, col] == 'P')
                            {
                                playerLost = true;
                            }

                            newMatrix[row - 1, col] = 'B';
                        }

                        if (IsCellValid(row + 1, col, matrix))
                        {
                            if (matrix[row + 1, col] == 'P')
                            {
                                playerLost = true;
                            }

                            newMatrix[row + 1, col] = 'B';
                        }

                        if (IsCellValid(row, col - 1, matrix))
                        {
                            if (matrix[row, col - 1] == 'P')
                            {
                                playerLost = true;
                            }

                            newMatrix[row, col - 1] = 'B';
                        }

                        if (IsCellValid(row, col + 1, matrix))
                        {
                            if (matrix[row, col + 1] == 'P')
                            {
                                playerLost = true;
                            }

                            newMatrix[row, col + 1] = 'B';
                        }
                    }
                }
            }

            return newMatrix;
        }

        static bool IsCellValid(int row, int col, char[,] matrix)
        {
            return row >= 0
                && row < matrix.GetLength(0)
                && col >= 0
                && col < matrix.GetLength(1);
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }



        static char[,] CopyMatrix(char[,] matrix)
        {
            char[,] matrixCopy = new char[matrix.GetLength(0), matrix.GetLength(1)];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrixCopy[row, col] = matrix[row, col];
                }
            }

            return matrixCopy;
        }
    }
}