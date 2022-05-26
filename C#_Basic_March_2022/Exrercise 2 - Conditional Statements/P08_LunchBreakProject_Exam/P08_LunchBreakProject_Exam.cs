using System;

namespace P08_LunchBreakProject_Exam
{
    class P08_LunchBreakProject_Exam
    {
        static void Main()
        {
            string movieName = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            int breakDuration = int.Parse(Console.ReadLine());

            double lunchTime = breakDuration / 8.0;
            double freeTime = breakDuration / 4.0;

            double timeLeft = breakDuration - lunchTime - freeTime;

            if (timeLeft >= episodeDuration)
            {
                double freeTimeLeft = timeLeft - episodeDuration;
                Console.WriteLine($"You have enough time to watch {movieName} and left with {Math.Ceiling(freeTimeLeft)} minutes free time.");
            }
            else
            {
                double neededTime = episodeDuration - timeLeft;
                Console.WriteLine($"You don't have enough time to watch {movieName}, you need {Math.Ceiling(neededTime)} more minutes.");
            }
        }
    }
}