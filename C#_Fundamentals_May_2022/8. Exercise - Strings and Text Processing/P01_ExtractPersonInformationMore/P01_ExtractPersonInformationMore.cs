using System;
using System.Collections.Generic;

namespace P01_ExtractPersonInformationMore
{
    internal class P01_ExtractPersonInformationMore
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfLines; i++)
            {
                string input = Console.ReadLine();

                int indexOfNameStart = input.IndexOf('@');
                int indexOfNameEnd = input.IndexOf('|');
                string name = input.Substring(indexOfNameStart + 1, indexOfNameEnd - indexOfNameStart - 1);

                int indexOfAgeStart = input.IndexOf('#');
                int indexOfAgeEnd = input.IndexOf('*');
                string age = input.Substring(indexOfAgeStart + 1, indexOfAgeEnd - indexOfAgeStart -1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}