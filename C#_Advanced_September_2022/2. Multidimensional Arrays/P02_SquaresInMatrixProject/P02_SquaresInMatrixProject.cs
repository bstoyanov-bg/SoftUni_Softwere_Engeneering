using System;
using System.Linq;

namespace P02_SquaresInMatrixProject
{
    internal class P02_SquaresInMatrixProject
    {
        static void Main(string[] args)
        {
            int subMatrixRows = 2;
            int subMatrixCols = 2;

            string[] size = Console.ReadLine().Split(' ');
            int rows = int.Parse(size[0]);
            int cols = int.Parse(size[1]);

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int count = 0;

            for (int row = 0; row < rows - subMatrixRows + 1; row++)
            {
                for (int col = 0; col < cols - subMatrixCols + 1; col++)
                {
                    string first = matrix[row, col];
                    string second = matrix[row + 1, col];
                    string third = matrix[row, col + 1];
                    string fourth = matrix[row + 1, col + 1];

                    if (first == second && second == third && third == fourth)
                    {
                        count ++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}