using System;
using System.Linq;

namespace P03_ZigZagArraysProject
{
    class P03_ZigZagArraysProject
    {
        static void Main(string[] args)
        {
            int linesNum = int.Parse(Console.ReadLine());
            int[] evenArray = new int[linesNum];
            int[] oddArray = new int[linesNum];

            for (int i = 0; i < linesNum; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    evenArray[i] = numbers[0];
                    oddArray[i] = numbers[1];
                }
                else
                {
                    evenArray[i] = numbers[1];
                    oddArray[i] = numbers[0];
                }
            }

            Console.WriteLine(string.Join(" ", evenArray));
            Console.WriteLine(string.Join(" ", oddArray));
        }
    }
}