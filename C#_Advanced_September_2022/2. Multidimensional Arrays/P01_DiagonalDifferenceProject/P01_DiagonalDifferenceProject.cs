using System;

namespace P01_DiagonalDifferenceProject
{
    internal class P01_DiagonalDifferenceProject
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int rows = size;
            int cols = size;

            int[,] matrix = new int[rows,cols];

            for (int row = 0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine().Split(' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(rowData[col]);
                }
            }

            int rightSumDiagonal = 0;
            int leftSumDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                rightSumDiagonal += matrix[i,i];
                leftSumDiagonal += matrix[i,matrix.GetLength(0) - 1 - i];
            }

            int difference = Math.Abs(rightSumDiagonal - leftSumDiagonal);

            Console.WriteLine(difference);
        }
    }
}