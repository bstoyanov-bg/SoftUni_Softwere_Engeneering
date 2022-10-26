using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace P08_BalancedParenthesisProject
{
    internal class P08_BalancedParenthesisProject
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            var stack = new Stack<char>();

            foreach (var charr in input)
            {
                if (charr == '{' || charr == '[' || charr == '(')
                {
                    stack.Push(charr);
                }
                else if (input.Length % 2 != 0)
                {
                    break;
                }
                else
                {
                    if (stack.Peek() == '{' & charr == '}')
                    {
                        stack.Pop();
                    }
                    else if (stack.Peek() == '[' & charr == ']')
                    {
                        stack.Pop();
                    }
                    else if (stack.Peek() == '(' & charr == ')')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}