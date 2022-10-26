using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05_SnakeMovesProject
{
    internal class P05_SnakeMovesProject
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int cols = size[1];

            string textInput = Console.ReadLine();
            char[] chars = textInput.ToCharArray();

            var queue = new Queue<char>();

            char[,] matrix = new char[rows, cols];

            for (int i = 0; i < (rows * cols) / textInput.Length + 1; i++)
            {
                foreach (char charr in chars)
                {
                    queue.Enqueue(charr);
                }
            }

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = queue.Dequeue();
                    }
                }
                else if (row % 2 != 0)
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = queue.Dequeue();
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}