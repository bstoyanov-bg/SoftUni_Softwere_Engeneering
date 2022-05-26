using System;

namespace P04_RequiredLiteratureProject
{
    class P04_RequiredLiteratureProject
    {
        static void Main()
        {
            int pageNumbersInBook = int.Parse(Console.ReadLine());
            int readPageNumbersForOneHour = int.Parse(Console.ReadLine());
            int daysForReading = int.Parse(Console.ReadLine());

            int allHoursReadingBook = pageNumbersInBook / readPageNumbersForOneHour;
            int neededHoursPerDay = allHoursReadingBook / daysForReading;

            Console.WriteLine(neededHoursPerDay);
        }
    }
}