using System;

namespace P08_LettersChangeNumbersProject
{
    internal class P08_LettersChangeNumbersProject
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (var item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];

                double result = 0;
                double number = int.Parse(item.Substring(1, item.Length - 2));
                

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    int firstLetterPositionInAlphabet = firstLetter - 64;
                    result = number / firstLetterPositionInAlphabet;
                }
                else
                {
                    int firstLetterPositionInAlphabet = firstLetter - 96;
                    result = number * firstLetterPositionInAlphabet;
                }

                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    int lastLetterPositionInAlphabet = lastLetter - 64;
                    sum += result - lastLetterPositionInAlphabet;
                }
                else
                {
                    int lastLetterPositionInAlphabet = lastLetter - 96;
                    sum += result + lastLetterPositionInAlphabet;
                }
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}