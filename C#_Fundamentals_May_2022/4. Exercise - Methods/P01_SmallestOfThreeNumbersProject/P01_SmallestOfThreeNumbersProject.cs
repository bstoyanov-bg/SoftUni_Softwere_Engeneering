using System;

namespace P01_SmallestOfThreeNumbersProject
{
    class P01_SmallestOfThreeNumbersProject
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNumber(firstNum, secondNum, thirdNum));
        }

        static int SmallestNumber(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }
    }
}