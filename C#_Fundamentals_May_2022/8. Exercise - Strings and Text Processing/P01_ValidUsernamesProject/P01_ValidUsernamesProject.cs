using System;
using System.Collections.Generic;
using System.Text;

namespace P01_ValidUsernamesProject
{
    internal class P01_ValidUsernamesProject
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> validWords = new List<string>();

            foreach (var word in input)
            {
                if (word.Length >= 3 && word.Length <= 16)
                {
                    bool isValid = true;
                    for (int i = 0; i < word.Length; i++)
                    {
                        char currentChar = word[i];

                        if (!(currentChar == '-' || currentChar == '_' || char.IsLetterOrDigit(currentChar)))
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        validWords.Add(word);
                    }
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine,validWords));
        }
    }
}