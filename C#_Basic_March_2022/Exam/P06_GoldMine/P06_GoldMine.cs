using System;

namespace P06_GoldMine
{
    class P06_GoldMine
    {
        static void Main()
        {
            int numOfLocations = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numOfLocations; i++)
            {
                double expectedAverageDayGold = double.Parse(Console.ReadLine());
                int numOfDaysForLocation = int.Parse(Console.ReadLine());
                double goldMinedForDayLocation = 0;

                for (int j = 1; j <= numOfDaysForLocation; j++)
                {
                    double goldMinedForDay = double.Parse(Console.ReadLine());
                    goldMinedForDayLocation += goldMinedForDay;
                }

                double averageMinedGoldForLocation = goldMinedForDayLocation / numOfDaysForLocation;

                if (averageMinedGoldForLocation >= expectedAverageDayGold)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageMinedGoldForLocation:f2}.");
                }
                else 
                {
                    double neededGold = expectedAverageDayGold - averageMinedGoldForLocation;
                    Console.WriteLine($"You need {neededGold:f2} gold.");
                }
            }
        }
    }
}