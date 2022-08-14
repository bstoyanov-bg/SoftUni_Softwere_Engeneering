using System;

namespace P10_TopNumberProject
{
    class P10_TopNumberProject
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());

            PrintTopNumbers(endNum);
        }

        static void PrintTopNumbers(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (IsDigitSumDivisibleByEighth(i) && HasOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool HasOddDigit(int number)
        {
            while (number > 0)
            {
                if ((number % 10) % 2 == 1)
                return true;
                number /= 10;
            }

            return false;
        }

        static bool IsDigitSumDivisibleByEighth(int number)
        {
            int currDigitSum = 0;
            while (number > 0)
            {
                currDigitSum += number % 10;
                number /= 10;
            }

            if (currDigitSum % 8 == 0)
            {
                return true;
            }

            return false;
        }

    }
}