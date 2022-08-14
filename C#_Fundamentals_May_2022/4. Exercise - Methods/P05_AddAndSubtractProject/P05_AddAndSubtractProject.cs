using System;
using System.Linq;

namespace P05_AddAndSubtractProject
{
    class P05_AddAndSubtractProject
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int addedResult = AddNumbers(firstNum, secondNum);
            int finalResult = SubtracktNumbers(addedResult, thirdNum);

            Console.WriteLine(finalResult);
        }
        static int SubtracktNumbers(int result, int thirdNum) => result - thirdNum;

        static int AddNumbers(int firstNum, int secondNum) => firstNum + secondNum;
    }
}