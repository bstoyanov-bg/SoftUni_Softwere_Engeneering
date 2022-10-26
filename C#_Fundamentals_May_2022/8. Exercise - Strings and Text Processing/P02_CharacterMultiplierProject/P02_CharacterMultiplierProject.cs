using System;

namespace P02_CharacterMultiplierProject
{
    internal class P02_CharacterMultiplierProject
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            CharacterMultiplier(input[0], input[1]);
        }

        private static void CharacterMultiplier(string first, string second)
        {
            int tottalSum = 0;
            char[] charArrOne = first.ToCharArray();
            char[] charArrTwo = second.ToCharArray();

            int shortestWord = Math.Min(first.Length, second.Length);

            for (int i = 0; i < shortestWord; i++)
            {
                int numOne = first[i];
                int numTwo = second[i];

                tottalSum += numOne * numTwo;
            }

            if (first.Length > second.Length)
            {
                for (int i = 0; i < first.Length - shortestWord; i++)
                {
                    tottalSum += first[i + shortestWord];
                }
            }
            else
            {
                for (int i = 0; i < second.Length - shortestWord; i++)
                {
                    tottalSum += second[i + shortestWord];
                }
            }

            Console.WriteLine(tottalSum);
        }
    }
}