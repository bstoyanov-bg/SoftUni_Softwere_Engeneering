using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P01_BasicStackOperationsProject
{
    internal class P01_BasicStackOperationsProject
    {
        static void Main(string[] args)
        {
            int[] stackArgs = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int n = stackArgs[0];
            int remove = stackArgs[1];
            int find = stackArgs[2];

            var stack = new Stack<int>(numbers);

            for (int i = 0; i < remove; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(find))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(stack.Count);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}