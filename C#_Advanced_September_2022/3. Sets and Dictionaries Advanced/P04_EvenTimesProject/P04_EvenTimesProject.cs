using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_EvenTimesProject
{
    internal class P04_EvenTimesProject
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < number; i++)
            {
                int count = 1;
                int currNum = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(currNum))
                {
                    dict.Add(currNum, 0);
                }

                dict[currNum]++;
            }

            Console.WriteLine(dict.Single(n => n.Value % 2 == 0).Key);
        }
    }
}