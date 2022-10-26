using System;
using System.Text;

namespace P06_ReplaceRepeatingCharsProject
{
    internal class P06_ReplaceRepeatingCharsProject
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            char[] currentChar = input.ToCharArray();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (currentChar[i] == currentChar[i + 1])
                {
                    continue;
                }

                sb.Append(currentChar[i]);
            }

            for (int i = input.Length - 1; i > input.Length - 2; i--)
            {
                if (currentChar[i] != currentChar[i-1])
                {
                    sb.Append(currentChar[i]);
                }
                else
                {
                    sb.Append(currentChar[i]);
                }
            }

            Console.WriteLine(sb);
        }
    }
}