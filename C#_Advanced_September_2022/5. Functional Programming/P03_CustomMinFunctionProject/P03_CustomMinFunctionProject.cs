using System;
using System.Linq;

namespace P03_CustomMinFunctionProject
{
    internal class P03_CustomMinFunctionProject
    {
        static void Main(string[] args)
        {
            Func<int[], int> min = numbers =>
            {
                int min = int.MaxValue;

                foreach (var number in numbers)
                {
                    if (number < min)
                    {
                        min = number;
                    }
                }

                return min;
            };

            int[] inputNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(min(inputNumbers));
        }
    }
}