using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_PeriodicTableProject
{
    internal class P03_PeriodicTableProject
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                for (int j = 0; j < input.Length; j++)
                {
                    if (!set.Contains(input[j]))
                    {
                        set.Add(input[j]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", set.OrderBy(x=>x)));
        }
    }
}