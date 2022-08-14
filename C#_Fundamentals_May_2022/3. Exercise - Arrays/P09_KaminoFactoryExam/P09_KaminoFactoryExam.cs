using System;
using System.Linq;

namespace P09_KaminoFactoryExam
{
    class P09_KaminoFactoryExam
    {
        static void Main(string[] args)
        {
            // sequence length
            int sequenceLength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] DNA = new int[sequenceLength];
            int dnaSum = 0;
            int dnaCount = -1;
            int dnaStartIndex = -1;
            int dnaSamples = 0;
            int sample = 0;

            while (input != "Clone them!")
            {
                // current DNA info
                sample++;
                int[] currentDNA = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                // current DNA elements
                int currentCount = 0;
                int currentStartIndex = 0;
                int currentEndIndex = 0;
                int currentDnaSum = 0;
                bool isCurrentDnaBeter = false;

                int count = 0;
                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] != 1)
                    {
                        count = 0;
                        continue;
                    }

                    count++;
                    if (count > currentCount)
                    {
                        currentCount = count;
                        currentEndIndex = i;
                    }
                }

                // 00 11 0 1 => 11 (endIndex = 2) => (startIndex = 2 - 2 = 0 + 1 => 1)
                currentStartIndex = currentEndIndex - currentCount + 1;
                currentDnaSum = currentDNA.Sum();

                // check current DNA with best DNK

                if (currentCount > dnaCount)
                {
                    isCurrentDnaBeter = true;
                }
                else if (currentCount == dnaCount)
                {
                    if (currentStartIndex < dnaStartIndex)
                    {
                        isCurrentDnaBeter = true;
                    }
                    else if (currentStartIndex == dnaStartIndex)
                    {
                        if (currentDnaSum > dnaSum)
                        {
                            isCurrentDnaBeter = true;
                        }
                    }
                }

                if (isCurrentDnaBeter)
                {
                    DNA = currentDNA;
                    dnaCount = currentCount;
                    dnaStartIndex = currentStartIndex;
                    dnaSum = currentDnaSum;
                    dnaSamples = sample;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {dnaSamples} with sum: {dnaSum}.");
            Console.WriteLine(String.Join(" ", DNA));
        }
    }
}