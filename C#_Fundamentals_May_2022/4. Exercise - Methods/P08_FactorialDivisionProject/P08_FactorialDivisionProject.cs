using System;

namespace P08_FactorialDivisionProject
{
    class P08_FactorialDivisionProject
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double resultOne = FactorialOfNumber(firstNum);
            double resultTwo = FactorialOfNumber(secondNum);

            Console.WriteLine($"{resultOne / resultTwo:f2}");
        }

        static double FactorialOfNumber(int number)
        {
            double result = 1.0;

            while (number != 1)
            {
                result *= number;
                number--;
            }
            return result;
        }
    }
}