using System;

namespace P07_NxN_MatrixProject
{
    class P07_NxN_MatrixProject
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            NxN_Matrix(number);
        }

        static void NxN_Matrix(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    Console.Write($"{number} ");
                }

            Console.WriteLine();
            }
        }
    }
}