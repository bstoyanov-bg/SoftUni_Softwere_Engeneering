using System;
using System.Collections.Generic;

namespace P01_CountCharsInAStringProject
{
    internal class P01_CountCharsInAStringProject
    {
        static void Main(string[] args)
        {
            char[] words = Console.ReadLine().ToCharArray();

            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (char letter in words)
            {
                if (letter != ' ')
                {
                    if (!letters.ContainsKey(letter))
                    {
                        letters[letter] = 0;
                    }
                    letters[letter]++;
                }
            }

            foreach (var keyLetter in letters)
            {
                Console.WriteLine($"{keyLetter.Key} -> {keyLetter.Value}");
            }
        }
    }
}