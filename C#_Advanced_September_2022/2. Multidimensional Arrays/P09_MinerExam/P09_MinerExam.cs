using System;
using System.Linq;

namespace P09_MinerExam
{
    internal class P09_MinerExam
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int rows = size;
            int cols = size;
            char[,] field = new char[rows, cols];

            string[] inputCommands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int coalsCount = 0;
            int startRow = 0;
            int startCol = 0;

            for (int row = 0; row < rows; row++)
            {
                char[] chars = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => char.Parse(n))
                    .ToArray(); ;
                for (int col = 0; col < cols; col++)
                {
                    if (chars[col] == 's')
                    {
                        startRow = row;
                        startCol = col;
                    }
                    else if (chars[col] == 'c')
                    {
                        coalsCount++;
                    }

                    field[row, col] = chars[col];
                }


            }

            int currRow = startRow;
            int currCol = startCol;

            foreach (string command in inputCommands)
            {
                bool hasEndCome = false;
                if (command == "up")
                {
                    if (currRow > 0)
                    {
                        currRow--;
                        hasEndCome = ProcessCell(currRow, currCol, ref coalsCount, field);
                    }
                }
                else if (command == "down")
                {
                    if (currRow < size - 1)
                    {
                        currRow++;
                        hasEndCome = ProcessCell(currRow, currCol, ref coalsCount, field);
                    }
                }
                else if (command == "left")
                {
                    if (currCol > 0)
                    {
                        currCol--;
                        hasEndCome = ProcessCell(currRow, currCol, ref coalsCount, field);
                    }
                }
                else if (command == "right")
                {
                    if (currCol < size - 1)
                    {
                        currCol++;
                        hasEndCome = ProcessCell(currRow, currCol, ref coalsCount, field);
                    }
                }

                if (hasEndCome)
                {
                    break;
                }

            }

            if (field[currRow, currCol] == 'e')
            {
                Console.WriteLine($"Game over! ({currRow}, {currCol})");

                return;
            }

            if (coalsCount == 0)
            {
                Console.WriteLine($"You collected all coals! ({currRow}, {currCol})");

                return;
            }

            Console.WriteLine($"{coalsCount} coals left. ({currRow}, {currCol})");
        }

        static bool ProcessCell(int row, int col, ref int coalsCount, char[,] field)
        {
            switch (field[row, col])
            {
                case 'e':
                    return true;
                case 'c':
                    field[row, col] = '*';
                    coalsCount--;
                    if (coalsCount == 0)
                    {
                        return true;
                    }
                    return false;
                default:
                    return false;
            }
        }
    }
}