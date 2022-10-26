using System;
using System.Collections.Generic;

namespace P06_WardrobeProject
{
    internal class P06_WardrobeProject
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var clothesDict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                string[] clothesInput = input[2].Split(",");

                if (!clothesDict.ContainsKey(color))
                {
                    clothesDict[color] = new Dictionary<string, int>();
                }

                for (int j = 0; j < clothesInput.Length; j++)
                {
                    string currCloth = clothesInput[j];
                    if (!clothesDict[color].ContainsKey(currCloth))
                    {
                        clothesDict[color].Add(currCloth, 0);
                    }

                    clothesDict[color][currCloth]++;
                }
            }

            string[] searchedCloth = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in clothesDict)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var cloth in color.Value)
                {
                    if (searchedCloth[0] == color.Key && searchedCloth[1] == cloth.Key)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}