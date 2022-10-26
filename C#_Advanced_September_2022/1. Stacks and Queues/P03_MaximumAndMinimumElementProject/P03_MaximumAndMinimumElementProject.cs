using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_MaximumAndMinimumElementProject
{
    internal class P03_MaximumAndMinimumElementProject
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                var code = int.Parse(inputArgs[0]);

                if (code == 1)
                {
                    int numToAdd = int.Parse(inputArgs[1]);
                    stack.Push(numToAdd);
                }
                else if (code == 2)
                {
                    stack.Pop();
                }
                else if (code == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (code == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}