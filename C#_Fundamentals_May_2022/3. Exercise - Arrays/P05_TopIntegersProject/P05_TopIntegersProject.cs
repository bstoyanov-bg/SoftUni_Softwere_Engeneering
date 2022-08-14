using System;
using System.Linq;

namespace P05_TopIntegersProject
{
    class P05_TopIntegersProject
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool currentItterationNumIsBigger = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        currentItterationNumIsBigger = false;
                    }
                }
                if (currentItterationNumIsBigger)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}