using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_SetsOfElementsProject
{
    internal class P02_SetsOfElementsProject
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            var firstSet = new HashSet<int>(numbers[0]);
            var secondSet = new HashSet<int>(numbers[1]);
            var finalSet = new HashSet<int>();

            for (int i = 0; i < numbers[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int j = 0; j < numbers[1]; j++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var num1 in firstSet)
            {
                foreach (var num2 in secondSet)
                {
                    if (num1 == num2)
                    {
                        finalSet.Add(num1);
                    }
                }
            }

            //firstSet.IntersectWith(secondSet);

            Console.WriteLine(string.Join(" ", finalSet));
            //Console.WriteLine(string.Join(" ", firstSet));
        }
    }
}