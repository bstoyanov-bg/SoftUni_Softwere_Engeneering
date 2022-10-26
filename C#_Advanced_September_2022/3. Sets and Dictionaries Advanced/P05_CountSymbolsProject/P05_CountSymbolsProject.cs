using System;
using System.Collections.Generic;

namespace P05_CountSymbolsProject
{
    internal class P05_CountSymbolsProject
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            var charDict = new SortedDictionary<char, int>();

            for (int i = 0; i < inputText.Length; i++)
            {
                char currChar = inputText[i];
                if (!charDict.ContainsKey(currChar))
                {
                    charDict.Add(currChar, 0);
                }

                charDict[currChar]++;
            }

            foreach (var charr in charDict)
            {
                Console.WriteLine($"{charr.Key}: {charr.Value} time/s");
            }
        }
    }
}