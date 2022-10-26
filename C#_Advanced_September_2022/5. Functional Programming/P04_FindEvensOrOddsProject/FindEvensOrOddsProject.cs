using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_FindEvensOrOddsProject
{
    internal class FindEvensOrOddsProject
    {
        static void Main(string[] args)
        {

            Predicate<int> even = number => number % 2 == 0;
            Predicate<int> odd = number => number % 2 != 0;

            int[] numbersRange = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isEven = Console.ReadLine() == "even";

            List<int> numbers = new List<int>();
            List<int> resultNumbers = new List<int>();

            for (int i = numbersRange[0]; i <= numbersRange[1]; i++)
            {
                numbers.Add(i);
            }

            if (isEven)
            {
                resultNumbers = numbers.FindAll(even);
            }
            else
            {
                resultNumbers = numbers.FindAll(odd);
            }

            Console.WriteLine(string.Join(" ", resultNumbers));
        }
    }
}