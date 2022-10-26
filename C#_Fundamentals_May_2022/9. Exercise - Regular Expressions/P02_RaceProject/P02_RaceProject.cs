using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02_RaceProject
{
    internal class P02_RaceProject
    {
        static void Main(string[] args)
        {
            // Create pattern for finding names of participants.
            Regex patternForName = new Regex(@"(?<name>[A-Za-z])");
            // Create pattern for finding digits.
            string patternForDigits = @"(?<digits>\d)";
            // Create variable for Sum of digits.
            int sumOfDigits = 0;
            // Create "Dictionary" for the participants
            var participants = new Dictionary<string, int>();
            // Create "List" for the names of participants.
            var names = Console.ReadLine().Split(", ").ToList();
            // Reading the input.
            string input = Console.ReadLine();

            // MAIN LOGIC:

            while (input != "end of race")
            {
                // Finding the names in Array[]
                MatchCollection matchedNames = patternForName.Matches(input);
                // Finding the digits in Array[]
                MatchCollection matchedDigits = Regex.Matches(input, patternForDigits);

                // Writeing current name in variable.
                string currName = string.Join("", matchedNames);
                // Writeing current digits in variable.
                string currDigits = string.Join("", matchedDigits);

                // Reset sum of digits.
                sumOfDigits = 0;

                for (int i = 0; i < currDigits.Length; i++)
                {
                    // Convert current digit in integer.
                    sumOfDigits += int.Parse(currDigits[i].ToString());
                }

                // Check if current participant exist in list of names?
                if (names.Contains(currName))
                {
                    // Check if participant name is not existing in Dictionary?
                    if (!participants.ContainsKey(currName))
                    {
                        // Add current name and sum of digits.
                        participants.Add(currName, sumOfDigits);
                    }
                    else
                    {
                        // Update current kilometers of the run.
                        participants[currName] += sumOfDigits;
                    }
                }

                input = Console.ReadLine();
            }
            // Finding the winners.

            int counter = 0;
            foreach (var item in participants.OrderByDescending(x => x.Value))
            {
                counter++;

                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }

                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }

                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                    break;
                }
            }
        }
    }
}